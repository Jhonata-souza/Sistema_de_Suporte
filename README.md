# Sistema de Suporte Técnico com IA

O **Sistema de Suporte Técnico com IA** é uma aplicação desenvolvida para Fazer atendimentos rapidos com Inteligência Artificial, gerenciar chamados, técnicos, atendimentos e usuários de forma simples e eficiente.  
O sistema organiza solicitações, facilita o acompanhamento dos chamados e registra todas as soluções aplicadas pelos técnicos.

---

## Funcionalidades Principais

### 👤 Usuários
- Cadastro de usuários com nome, email e senha.
- Login seguro.
- Associação entre usuários e chamados abertos.

### 🛠 Chamados
- Abertura de chamados com descrição, categoria e prioridade.
- Consulta dos chamados abertos, em andamento e concluídos.
- Atualização de status (Aberto → Em Andamento → Concluído).
- Registro automático de data de abertura e fechamento.

### 👨‍🔧 Técnicos
- Cadastro de técnicos com nome e email.
- Identificação automática do técnico logado pelo email.
- Vínculo entre atendimento e técnico responsável.

### 📝 Atendimentos
- Registro da solução aplicada ao chamado.
- Listagem do histórico de atendimentos.
- Associação entre técnico e chamado atendido.

### 🗄 Banco de Dados
Tabelas do sistema:
- `TBUsuarios`
- `TBTecnicos`
- `TBChamados`
- `TBAtendimentos`
- `TBSugestoesIA`
- `TBLogsLGPD`

---

## 🔐 Segurança

- Emails únicos para evitar duplicidade.
- Campos obrigatórios validados no banco.
- Identificação do usuário/técnico logado para filtrar dados.
