namespace Sistema_de_Suporte
{
    partial class TelaPrincipal
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
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonConta = new System.Windows.Forms.Button();
            this.buttonChamados = new System.Windows.Forms.Button();
            this.buttonPrincipal = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.Controls.Add(this.listView1);
            this.panelSideBar.Controls.Add(this.buttonConta);
            this.panelSideBar.Controls.Add(this.buttonChamados);
            this.panelSideBar.Controls.Add(this.buttonPrincipal);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(135, 568);
            this.panelSideBar.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 140);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(135, 351);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonConta
            // 
            this.buttonConta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConta.Location = new System.Drawing.Point(0, 497);
            this.buttonConta.Name = "buttonConta";
            this.buttonConta.Size = new System.Drawing.Size(135, 59);
            this.buttonConta.TabIndex = 0;
            this.buttonConta.Text = "Conta";
            this.buttonConta.UseVisualStyleBackColor = true;
            this.buttonConta.Click += new System.EventHandler(this.buttonConta_Click);
            // 
            // buttonChamados
            // 
            this.buttonChamados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChamados.Location = new System.Drawing.Point(0, 77);
            this.buttonChamados.Name = "buttonChamados";
            this.buttonChamados.Size = new System.Drawing.Size(135, 59);
            this.buttonChamados.TabIndex = 0;
            this.buttonChamados.Text = "Chamados";
            this.buttonChamados.UseVisualStyleBackColor = true;
            this.buttonChamados.Click += new System.EventHandler(this.buttonChamados_Click);
            // 
            // buttonPrincipal
            // 
            this.buttonPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrincipal.Location = new System.Drawing.Point(0, 12);
            this.buttonPrincipal.Name = "buttonPrincipal";
            this.buttonPrincipal.Size = new System.Drawing.Size(135, 59);
            this.buttonPrincipal.TabIndex = 0;
            this.buttonPrincipal.Text = "Tela inicial";
            this.buttonPrincipal.UseVisualStyleBackColor = true;
            this.buttonPrincipal.Click += new System.EventHandler(this.buttonPrincipal_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(135, 0);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(769, 568);
            this.panelConteudo.TabIndex = 1;
            this.panelConteudo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConteudo_Paint);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 568);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelSideBar);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.panelSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Button buttonConta;
        private System.Windows.Forms.Button buttonChamados;
        private System.Windows.Forms.Button buttonPrincipal;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.ListView listView1;
    }
}