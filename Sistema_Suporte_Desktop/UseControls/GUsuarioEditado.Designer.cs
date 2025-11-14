namespace Sistema_de_Suporte
{
    partial class GUsuarioEditado
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
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxValor
            // 
            this.textBoxValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxValor.Location = new System.Drawing.Point(356, 327);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(138, 20);
            this.textBoxValor.TabIndex = 22;
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(315, 330);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(31, 13);
            this.label.TabIndex = 21;
            this.label.Text = "Valor";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEdit.Location = new System.Drawing.Point(318, 368);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 23;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(356, 249);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(30, 20);
            this.textBoxID.TabIndex = 18;
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(315, 252);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 17;
            this.labelId.Text = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Campo";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Items.AddRange(new object[] {
            "Nome",
            "Email"});
            this.comboBoxCampo.Location = new System.Drawing.Point(356, 291);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCampo.TabIndex = 25;
            // 
            // GUsuarioEditado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelId);
            this.Name = "GUsuarioEditado";
            this.Size = new System.Drawing.Size(830, 640);
            this.Load += new System.EventHandler(this.GUsuarioEditado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCampo;
    }
}
