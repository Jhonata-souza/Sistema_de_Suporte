using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenAI; // Namespace principal do SDK OpenAI
using OpenAI.Chat; // Namespace para funcionalidades de chat

using System.Text.Json;
using DotNetEnv;

using Microsoft.Data.SqlClient;
using System.Net.Http;

namespace Sistema_de_Suporte
{
// Classe auxiliar para retornar ambos os resultados
    public class RespostaChat
    {
        public Chamado Chamado { get; set; } // só será preenchido na primeira mensagem
        public string MensagemIA { get; set; }
    }

    internal class ChatService
    {
        private readonly OpenAIClient client;
        private readonly ChatClient chatClient;

        private bool primeiraMensagem = true;
        private Usuario idUsuario;
        private Banco banco = new Banco();

        public ChatService(Usuario idUsuarioLogado)
        {
            Env.Load();

            string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

            if (string.IsNullOrEmpty(apiKey))
                throw new Exception("A chave da API não foi encontrada. Verifique o arquivo .env ou as variáveis de ambiente.");

            client = new OpenAIClient(apiKey);
            chatClient = client.GetChatClient("gpt-4o-mini");

            idUsuario = idUsuarioLogado;
        }

        // Método principal de envio de mensagens
        public async Task<RespostaChat> EnviarMensagemAsync(string mensagem)
        {
            try
            {
                var respostaChat = new RespostaChat();

                if (primeiraMensagem)
                {
                    primeiraMensagem = false;

                    // Classifica a primeira mensagem e cria o Chamado
                    string jsonClassificacao = await ClassificarPrimeiraMensagemAsync(mensagem);
                    respostaChat.Chamado = Chamado.FromJson(jsonClassificacao, idUsuario.Id);
                }

                // Envia a mensagem normalmente para a IA
                var userMessage = ChatMessage.CreateUserMessage(mensagem);
                var resposta = await chatClient.CompleteChatAsync(new[] { userMessage });

                respostaChat.MensagemIA = resposta.Value.Content[0].Text.Trim();

                // Registra sugestão da IA
                if (respostaChat.Chamado != null)
                {
                    Console.WriteLine($"{respostaChat.Chamado.IdChamado},{respostaChat.Chamado.Categoria}, { respostaChat.MensagemIA}");

                    RegistrarSugestaoIA(
                        respostaChat.Chamado.IdChamado,
                        respostaChat.Chamado.Categoria,
                        respostaChat.MensagemIA
                    );
                }

                return respostaChat;
            }
            catch (Exception ex)
            {
                return new RespostaChat
                {
                    MensagemIA = $"[ERRO] Falha ao comunicar com a IA: {ex.Message}",
                    Chamado = primeiraMensagem ? new Chamado
                    {
                        Descricao = "Erro ao classificar a mensagem",
                        Categoria = "Desconhecida",
                        Prioridade = "Baixa"
                    } : null
                };
            }
        }

        // Método usado somente para a primeira mensagem (classificação)
        public async Task<string> ClassificarPrimeiraMensagemAsync(string mensagem)
        {
            try
            {
                var systemMessage = ChatMessage.CreateSystemMessage(
                    "Você é um assistente de suporte técnico. Ao receber a primeira mensagem do usuário, " +
                    "retorne um JSON no formato {\"descricao\":\"...\",\"categoria\":\"...\",\"prioridade\":\"...\"}. " +
                    "As categorias possíveis são: 'Acesso', 'Erro', 'Desempenho', 'Pagamento', 'Outros'. " +
                    "A prioridade pode ser: 'baixa', 'media' ou 'alta'."
                );

                var userMessage = ChatMessage.CreateUserMessage(mensagem);

                var resposta = await chatClient.CompleteChatAsync(new ChatMessage[] { systemMessage, userMessage });

                return resposta.Value.Content[0].Text.Trim();
            }
            catch (Exception ex)
            {
                return $"{{\"descricao\":\"Erro ao classificar a mensagem: {ex.Message}\",\"categoria\":\"Desconhecida\",\"prioridade\":\"Baixa\"}}";
            }
        }

        // NOVO: Registra sugestão da IA na tabela TBSugestoesIA
        private void RegistrarSugestaoIA(int idChamado, string categoria, string solucao)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    decimal acuracia = new Random().Next(70, 101); // Gera aleatório entre 70 e 100

                    string query = @"
                        INSERT INTO TBSugestoesIA (id_chamado, categoria_sugerida, solucao_sugerida, acuracia)
                        VALUES (@id_chamado, @categoria, @solucao, @acuracia);
                    ";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id_chamado", idChamado);
                        cmd.Parameters.AddWithValue("@categoria", categoria);
                        cmd.Parameters.AddWithValue("@solucao", solucao);
                        cmd.Parameters.AddWithValue("@acuracia", acuracia);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar sugestão da IA: {ex.Message}");
            }
        }
    }
}