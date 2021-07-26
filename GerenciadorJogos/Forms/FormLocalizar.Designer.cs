
namespace GerenciadorJogos.Forms
{
    partial class FormLocalizar
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
            this.lstDados = new System.Windows.Forms.ListBox();
            this.cboCodigo = new System.Windows.Forms.ComboBox();
            this.cboNome = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarJogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDados
            // 
            this.lstDados.FormattingEnabled = true;
            this.lstDados.ItemHeight = 15;
            this.lstDados.Location = new System.Drawing.Point(12, 119);
            this.lstDados.Name = "lstDados";
            this.lstDados.Size = new System.Drawing.Size(403, 124);
            this.lstDados.TabIndex = 0;
            // 
            // cboCodigo
            // 
            this.cboCodigo.Enabled = false;
            this.cboCodigo.FormattingEnabled = true;
            this.cboCodigo.Location = new System.Drawing.Point(95, 22);
            this.cboCodigo.Name = "cboCodigo";
            this.cboCodigo.Size = new System.Drawing.Size(121, 23);
            this.cboCodigo.TabIndex = 26;
            // 
            // cboNome
            // 
            this.cboNome.FormattingEnabled = true;
            this.cboNome.Location = new System.Drawing.Point(95, 52);
            this.cboNome.Name = "cboNome";
            this.cboNome.Size = new System.Drawing.Size(121, 23);
            this.cboNome.TabIndex = 25;
            this.cboNome.SelectedIndexChanged += new System.EventHandler(this.cboNome_SelectedIndexChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(320, 76);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Código";
            // 
            // btnBuscarJogo
            // 
            this.btnBuscarJogo.Location = new System.Drawing.Point(320, 21);
            this.btnBuscarJogo.Name = "btnBuscarJogo";
            this.btnBuscarJogo.Size = new System.Drawing.Size(75, 49);
            this.btnBuscarJogo.TabIndex = 21;
            this.btnBuscarJogo.Text = "Buscar Jogo";
            this.btnBuscarJogo.UseVisualStyleBackColor = true;
            this.btnBuscarJogo.Click += new System.EventHandler(this.btnBuscarJogo_Click);
            // 
            // FormLocalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 258);
            this.Controls.Add(this.cboCodigo);
            this.Controls.Add(this.cboNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarJogo);
            this.Controls.Add(this.lstDados);
            this.Name = "FormLocalizar";
            this.Text = "FormLocalizar";
            this.Load += new System.EventHandler(this.FormLocalizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDados;
        private System.Windows.Forms.ComboBox cboCodigo;
        private System.Windows.Forms.ComboBox cboNome;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarJogo;
    }
}