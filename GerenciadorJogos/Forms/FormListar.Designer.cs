
namespace GerenciadorJogos.Forms
{
    partial class FormListar
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnListarJogos = new System.Windows.Forms.Button();
            this.lstDados = new System.Windows.Forms.ListBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboConsole = new System.Windows.Forms.ComboBox();
            this.ckbListarTodos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(320, 73);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 31;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnListarJogos
            // 
            this.btnListarJogos.Location = new System.Drawing.Point(320, 18);
            this.btnListarJogos.Name = "btnListarJogos";
            this.btnListarJogos.Size = new System.Drawing.Size(75, 49);
            this.btnListarJogos.TabIndex = 28;
            this.btnListarJogos.Text = "Listar Jogos";
            this.btnListarJogos.UseVisualStyleBackColor = true;
            this.btnListarJogos.Click += new System.EventHandler(this.btnListarJogos_Click);
            // 
            // lstDados
            // 
            this.lstDados.FormattingEnabled = true;
            this.lstDados.ItemHeight = 15;
            this.lstDados.Location = new System.Drawing.Point(12, 116);
            this.lstDados.Name = "lstDados";
            this.lstDados.Size = new System.Drawing.Size(403, 124);
            this.lstDados.TabIndex = 27;
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Todos"});
            this.cboGenero.Location = new System.Drawing.Point(98, 65);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 23);
            this.cboGenero.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Gênero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Console";
            // 
            // cboConsole
            // 
            this.cboConsole.FormattingEnabled = true;
            this.cboConsole.Items.AddRange(new object[] {
            "Todos"});
            this.cboConsole.Location = new System.Drawing.Point(98, 32);
            this.cboConsole.Name = "cboConsole";
            this.cboConsole.Size = new System.Drawing.Size(121, 23);
            this.cboConsole.TabIndex = 34;
            // 
            // ckbListarTodos
            // 
            this.ckbListarTodos.AutoSize = true;
            this.ckbListarTodos.Location = new System.Drawing.Point(231, 34);
            this.ckbListarTodos.Name = "ckbListarTodos";
            this.ckbListarTodos.Size = new System.Drawing.Size(88, 19);
            this.ckbListarTodos.TabIndex = 39;
            this.ckbListarTodos.Text = "Listar Todos";
            this.ckbListarTodos.UseVisualStyleBackColor = true;
            this.ckbListarTodos.CheckedChanged += new System.EventHandler(this.ckbListarTodos_CheckedChanged);
            // 
            // FormListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 258);
            this.Controls.Add(this.ckbListarTodos);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboConsole);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnListarJogos);
            this.Controls.Add(this.lstDados);
            this.Name = "FormListar";
            this.Text = "FormListar";
            this.Load += new System.EventHandler(this.FormListar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnListarJogos;
        private System.Windows.Forms.ListBox lstDados;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboConsole;
        private System.Windows.Forms.CheckBox ckbListarTodos;
    }
}