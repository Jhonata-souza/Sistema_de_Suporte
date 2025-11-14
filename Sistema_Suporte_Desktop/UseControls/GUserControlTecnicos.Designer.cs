namespace Sistema_de_Suporte
{
    partial class GUserControlTecnicos
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.panelTecnicos = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.Location = new System.Drawing.Point(462, 532);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 57);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Ativar/Desativa Tecnico";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEdit.Location = new System.Drawing.Point(284, 532);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(122, 57);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Editar Informações";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCadastro.Location = new System.Drawing.Point(106, 532);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(122, 57);
            this.buttonCadastro.TabIndex = 7;
            this.buttonCadastro.Text = "Cadastra novo Tecnico";
            this.buttonCadastro.UseVisualStyleBackColor = true;
            this.buttonCadastro.Click += new System.EventHandler(this.buttonCadastro_Click);
            // 
            // panelTecnicos
            // 
            this.panelTecnicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTecnicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTecnicos.Location = new System.Drawing.Point(622, 83);
            this.panelTecnicos.Name = "panelTecnicos";
            this.panelTecnicos.Size = new System.Drawing.Size(316, 429);
            this.panelTecnicos.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(478, 429);
            this.dataGridView1.TabIndex = 3;
            // 
            // GUserControlTecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCadastro);
            this.Controls.Add(this.panelTecnicos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GUserControlTecnicos";
            this.Size = new System.Drawing.Size(1045, 673);
            this.Load += new System.EventHandler(this.GUserControlTecnicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCadastro;
        private System.Windows.Forms.Panel panelTecnicos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
