namespace Sistema_de_Suporte
{
    partial class GTecnicoEditado
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelCampo = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(376, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 38;
            // 
            // labelValor
            // 
            this.labelValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(335, 315);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(31, 13);
            this.labelValor.TabIndex = 37;
            this.labelValor.Text = "Valor";
            // 
            // labelCampo
            // 
            this.labelCampo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(335, 276);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(40, 13);
            this.labelCampo.TabIndex = 35;
            this.labelCampo.Text = "Campo";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(401, 234);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(25, 20);
            this.textBoxID.TabIndex = 34;
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(335, 237);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(60, 13);
            this.labelID.TabIndex = 33;
            this.labelID.Text = "ID Tecnico";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEdit.Location = new System.Drawing.Point(338, 351);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 32;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Items.AddRange(new object[] {
            "Nome",
            "Email",
            "Especialidade"});
            this.comboBoxCampo.Location = new System.Drawing.Point(381, 273);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCampo.TabIndex = 39;
            // 
            // GTecnicoEditado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonEdit);
            this.Name = "GTecnicoEditado";
            this.Size = new System.Drawing.Size(837, 609);
            this.Load += new System.EventHandler(this.GTecnicoEditado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ComboBox comboBoxCampo;
    }
}
