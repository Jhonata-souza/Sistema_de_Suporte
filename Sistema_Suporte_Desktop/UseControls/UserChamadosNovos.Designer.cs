namespace Sistema_de_Suporte
{
    partial class UserChamadosNovos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelChat = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelChat
            // 
            this.flowLayoutPanelChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelChat.AutoScroll = true;
            this.flowLayoutPanelChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelChat.Location = new System.Drawing.Point(22, 35);
            this.flowLayoutPanelChat.Name = "flowLayoutPanelChat";
            this.flowLayoutPanelChat.Size = new System.Drawing.Size(941, 429);
            this.flowLayoutPanelChat.TabIndex = 0;
            this.flowLayoutPanelChat.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonEnviar);
            this.panel1.Controls.Add(this.textBoxInput);
            this.panel1.Location = new System.Drawing.Point(92, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 1;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(708, 38);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(48, 23);
            this.buttonEnviar.TabIndex = 1;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(42, 40);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(660, 20);
            this.textBoxInput.TabIndex = 0;
            // 
            // UserChamadosNovos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanelChat);
            this.Name = "UserChamadosNovos";
            this.Size = new System.Drawing.Size(984, 603);
            this.Load += new System.EventHandler(this.UserChamadosNovos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.TextBox textBoxInput;
    }
}
