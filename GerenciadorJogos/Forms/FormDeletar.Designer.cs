
namespace GerenciadorJogos.Forms
{
    partial class FormDeletar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeletar));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoverJogo = new System.Windows.Forms.Button();
            this.cboNome = new System.Windows.Forms.ComboBox();
            this.cboCodigo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(320, 83);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código";
            // 
            // btnRemoverJogo
            // 
            this.btnRemoverJogo.Location = new System.Drawing.Point(320, 28);
            this.btnRemoverJogo.Name = "btnRemoverJogo";
            this.btnRemoverJogo.Size = new System.Drawing.Size(75, 49);
            this.btnRemoverJogo.TabIndex = 13;
            this.btnRemoverJogo.Text = "Remover Jogo";
            this.btnRemoverJogo.UseVisualStyleBackColor = true;
            this.btnRemoverJogo.Click += new System.EventHandler(this.btnRemoverJogo_Click);
            // 
            // cboNome
            // 
            this.cboNome.FormattingEnabled = true;
            this.cboNome.Location = new System.Drawing.Point(95, 59);
            this.cboNome.Name = "cboNome";
            this.cboNome.Size = new System.Drawing.Size(121, 23);
            this.cboNome.TabIndex = 19;
            this.cboNome.SelectedIndexChanged += new System.EventHandler(this.cboNome_SelectedIndexChanged);
            // 
            // cboCodigo
            // 
            this.cboCodigo.Enabled = false;
            this.cboCodigo.FormattingEnabled = true;
            this.cboCodigo.Location = new System.Drawing.Point(95, 29);
            this.cboCodigo.Name = "cboCodigo";
            this.cboCodigo.Size = new System.Drawing.Size(121, 23);
            this.cboCodigo.TabIndex = 20;
            // 
            // FormDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 123);
            this.Controls.Add(this.cboCodigo);
            this.Controls.Add(this.cboNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoverJogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDeletar";
            this.Text = "Remover Jogo";
            this.Load += new System.EventHandler(this.FormDeletar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoverJogo;
        private System.Windows.Forms.ComboBox cboNome;
        private System.Windows.Forms.ComboBox cboCodigo;
    }
}