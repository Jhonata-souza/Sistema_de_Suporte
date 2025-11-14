using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Suporte
{
    public partial class UserChamadosNovos : UserControl
    {
        private ChatService chatService;
        private Usuario idUsuario;
        public UserChamadosNovos(Usuario idUsuarioLogado)
        {
            InitializeComponent();
            SetupFlowLayout();
            this.idUsuario = idUsuarioLogado;
        }

        private void SetupFlowLayout()
        {
            flowLayoutPanelChat.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelChat.WrapContents = false;
            flowLayoutPanelChat.AutoScroll = true;
            flowLayoutPanelChat.Padding = new Padding(10);
        }

        private async void buttonEnviar_Click(object sender, EventArgs e)
        {
            string texto = textBoxInput.Text.Trim();
            if (string.IsNullOrEmpty(texto)) return;

            AddMessage(texto, true); // mostra a mensagem do usuário
            textBoxInput.Clear();

            try
            {
                var chatService = new ChatService(idUsuario);

                // Envia a mensagem e recebe a resposta
                RespostaChat resposta = await chatService.EnviarMensagemAsync(texto);

                // Se houver Chamado (primeira mensagem), você pode salvar ou exibir
                if (resposta.Chamado != null)
                {
                    // Exemplo: exibir no console
                    Console.WriteLine("Chamado criado:");
                    Console.WriteLine(resposta.Chamado.ToString());
                }

                // Exibe a resposta da IA
                AddMessage(resposta.MensagemIA, false);
            }
            catch (Exception ex)
            {
                AddMessage($"[ERRO] {ex.Message}", false);
            }
        }


        private void AddMessage(string texto, bool isUser)
        {
            var bubble = new MessageBubble(texto, isUser, DateTime.Now);

            // Cria uma linha automática na altura e com largura controlada
            TableLayoutPanel row = new TableLayoutPanel();
            row.ColumnCount = 1;
            row.RowCount = 1;
            row.AutoSize = true; // Altura automática
            row.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            row.Margin = new Padding(5);
            row.Padding = new Padding(0);
            row.BackColor = Color.Transparent;

            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            // Define alinhamento do balão
            if (isUser)
            {
                bubble.Anchor = AnchorStyles.Right;
                bubble.Margin = new Padding(530, 0, 0, 0); // afastamento da borda direita
            }
            else
            {
                bubble.Anchor = AnchorStyles.Left;
                bubble.Margin = new Padding(0, 0, 0, 0); // afastamento da borda esquerda
            }

            row.Controls.Add(bubble, 0, 0);

            // Adiciona a linha ao FlowLayoutPanel
            flowLayoutPanelChat.Controls.Add(row);
            flowLayoutPanelChat.ScrollControlIntoView(row);
        }

        private void UserChamadosNovos_Load(object sender, EventArgs e)
        {
        }
    }
}
