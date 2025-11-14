namespace Sistema_de_Suporte
{
    partial class UserControlTecnico
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAtendimento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(707, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 398);
            this.panel1.TabIndex = 1;
            // 
            // buttonAtendimento
            // 
            this.buttonAtendimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAtendimento.Location = new System.Drawing.Point(338, 491);
            this.buttonAtendimento.Name = "buttonAtendimento";
            this.buttonAtendimento.Size = new System.Drawing.Size(108, 53);
            this.buttonAtendimento.TabIndex = 2;
            this.buttonAtendimento.Text = "Fazer Atendimento";
            this.buttonAtendimento.UseVisualStyleBackColor = true;
            this.buttonAtendimento.Click += new System.EventHandler(this.buttonAtendimento_Click);
            // 
            // UserControlTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAtendimento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControlTecnico";
            this.Size = new System.Drawing.Size(1047, 638);
            this.Load += new System.EventHandler(this.UserControlTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAtendimento;
    }
}
