
namespace GerenciadorJogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListar));
            this.ckbListarTodos = new System.Windows.Forms.CheckBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboConsole = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnListarJogos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbListarTodos
            // 
            this.ckbListarTodos.AutoSize = true;
            this.ckbListarTodos.Location = new System.Drawing.Point(231, 34);
            this.ckbListarTodos.Name = "ckbListarTodos";
            this.ckbListarTodos.Size = new System.Drawing.Size(88, 19);
            this.ckbListarTodos.TabIndex = 47;
            this.ckbListarTodos.Text = "Listar Todos";
            this.ckbListarTodos.UseVisualStyleBackColor = true;
            this.ckbListarTodos.CheckedChanged += new System.EventHandler(this.ckbListarTodos_CheckedChanged);
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Todos"});
            this.cboGenero.Location = new System.Drawing.Point(98, 65);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 23);
            this.cboGenero.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Gênero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Console";
            // 
            // cboConsole
            // 
            this.cboConsole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsole.FormattingEnabled = true;
            this.cboConsole.Items.AddRange(new object[] {
            "Todos"});
            this.cboConsole.Location = new System.Drawing.Point(98, 32);
            this.cboConsole.Name = "cboConsole";
            this.cboConsole.Size = new System.Drawing.Size(121, 23);
            this.cboConsole.TabIndex = 43;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(320, 73);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 42;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnListarJogos
            // 
            this.btnListarJogos.Location = new System.Drawing.Point(320, 18);
            this.btnListarJogos.Name = "btnListarJogos";
            this.btnListarJogos.Size = new System.Drawing.Size(75, 49);
            this.btnListarJogos.TabIndex = 41;
            this.btnListarJogos.Text = "Listar Jogos";
            this.btnListarJogos.UseVisualStyleBackColor = true;
            this.btnListarJogos.Click += new System.EventHandler(this.btnListarJogos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(403, 144);
            this.dataGridView1.TabIndex = 48;
            // 
            // FormListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 258);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ckbListarTodos);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboConsole);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnListarJogos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListar";
            this.Text = "Listar Jogo";
            this.Load += new System.EventHandler(this.FormTeste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbListarTodos;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboConsole;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnListarJogos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}