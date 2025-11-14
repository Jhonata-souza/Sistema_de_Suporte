namespace Sistema_de_Suporte
{
    partial class TelaDeGerenciamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSugestoes = new System.Windows.Forms.Button();
            this.buttonChamado = new System.Windows.Forms.Button();
            this.buttonAtendimento = new System.Windows.Forms.Button();
            this.buttonTecnico = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.gpanelConteudo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSugestoes);
            this.panel1.Controls.Add(this.buttonChamado);
            this.panel1.Controls.Add(this.buttonAtendimento);
            this.panel1.Controls.Add(this.buttonTecnico);
            this.panel1.Controls.Add(this.buttonLog);
            this.panel1.Controls.Add(this.buttonUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 565);
            this.panel1.TabIndex = 0;
            // 
            // buttonSugestoes
            // 
            this.buttonSugestoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSugestoes.Location = new System.Drawing.Point(0, 460);
            this.buttonSugestoes.Name = "buttonSugestoes";
            this.buttonSugestoes.Size = new System.Drawing.Size(158, 80);
            this.buttonSugestoes.TabIndex = 0;
            this.buttonSugestoes.Text = "Sugestões da IA";
            this.buttonSugestoes.UseVisualStyleBackColor = true;
            this.buttonSugestoes.Click += new System.EventHandler(this.buttonSugestoes_Click);
            // 
            // buttonChamado
            // 
            this.buttonChamado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChamado.Location = new System.Drawing.Point(0, 202);
            this.buttonChamado.Name = "buttonChamado";
            this.buttonChamado.Size = new System.Drawing.Size(158, 80);
            this.buttonChamado.TabIndex = 0;
            this.buttonChamado.Text = "Chamados";
            this.buttonChamado.UseVisualStyleBackColor = true;
            this.buttonChamado.Click += new System.EventHandler(this.buttonChamado_Click);
            // 
            // buttonAtendimento
            // 
            this.buttonAtendimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAtendimento.Location = new System.Drawing.Point(0, 288);
            this.buttonAtendimento.Name = "buttonAtendimento";
            this.buttonAtendimento.Size = new System.Drawing.Size(158, 80);
            this.buttonAtendimento.TabIndex = 0;
            this.buttonAtendimento.Text = "Atendimentos";
            this.buttonAtendimento.UseVisualStyleBackColor = true;
            this.buttonAtendimento.Click += new System.EventHandler(this.buttonAtendimento_Click);
            // 
            // buttonTecnico
            // 
            this.buttonTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTecnico.Location = new System.Drawing.Point(0, 122);
            this.buttonTecnico.Name = "buttonTecnico";
            this.buttonTecnico.Size = new System.Drawing.Size(158, 80);
            this.buttonTecnico.TabIndex = 0;
            this.buttonTecnico.Text = "Tecnicos";
            this.buttonTecnico.UseVisualStyleBackColor = true;
            this.buttonTecnico.Click += new System.EventHandler(this.buttonTecnico_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLog.Location = new System.Drawing.Point(0, 374);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(158, 80);
            this.buttonLog.TabIndex = 0;
            this.buttonLog.Text = "Logs de Usuario";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUsuario.Location = new System.Drawing.Point(0, 42);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Size = new System.Drawing.Size(158, 80);
            this.buttonUsuario.TabIndex = 0;
            this.buttonUsuario.Text = "Usuarios";
            this.buttonUsuario.UseVisualStyleBackColor = true;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // gpanelConteudo
            // 
            this.gpanelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpanelConteudo.Location = new System.Drawing.Point(158, 0);
            this.gpanelConteudo.Name = "gpanelConteudo";
            this.gpanelConteudo.Size = new System.Drawing.Size(763, 565);
            this.gpanelConteudo.TabIndex = 1;
            this.gpanelConteudo.Paint += new System.Windows.Forms.PaintEventHandler(this.gpanelConteudo_Paint);
            // 
            // TelaDeGerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 565);
            this.Controls.Add(this.gpanelConteudo);
            this.Controls.Add(this.panel1);
            this.Name = "TelaDeGerenciamento";
            this.Text = "TelaDeGerenciamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaDeGerenciamento_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel gpanelConteudo;
        private System.Windows.Forms.Button buttonChamado;
        private System.Windows.Forms.Button buttonTecnico;
        private System.Windows.Forms.Button buttonUsuario;
        private System.Windows.Forms.Button buttonSugestoes;
        private System.Windows.Forms.Button buttonAtendimento;
        private System.Windows.Forms.Button buttonLog;
    }
}