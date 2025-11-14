namespace Sistema_de_Suporte
{
    partial class GUsuarioTecnico
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
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonTecnico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Items.AddRange(new object[] {
            "Cliente",
            "Tecnico"});
            this.comboBoxCampo.Location = new System.Drawing.Point(393, 311);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCampo.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tipo";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(393, 272);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(30, 20);
            this.textBoxID.TabIndex = 27;
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(352, 275);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 26;
            this.labelId.Text = "ID";
            // 
            // buttonTecnico
            // 
            this.buttonTecnico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTecnico.Location = new System.Drawing.Point(355, 354);
            this.buttonTecnico.Name = "buttonTecnico";
            this.buttonTecnico.Size = new System.Drawing.Size(89, 30);
            this.buttonTecnico.TabIndex = 30;
            this.buttonTecnico.Text = "Alterar Tipo";
            this.buttonTecnico.UseVisualStyleBackColor = true;
            this.buttonTecnico.Click += new System.EventHandler(this.buttonTecnico_Click);
            // 
            // GUsuarioTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonTecnico);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelId);
            this.Name = "GUsuarioTecnico";
            this.Size = new System.Drawing.Size(866, 606);
            this.Load += new System.EventHandler(this.GUsuarioTecnico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonTecnico;
    }
}
