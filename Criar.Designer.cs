namespace GerenciadorDeTarefas
{
    partial class Criar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_nome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            tb_desc = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // tb_nome
            // 
            tb_nome.BackColor = Color.FromArgb(39, 39, 58);
            tb_nome.BorderStyle = BorderStyle.FixedSingle;
            tb_nome.ForeColor = Color.White;
            tb_nome.Location = new Point(69, 44);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(175, 23);
            tb_nome.TabIndex = 0;
            tb_nome.Text = "\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LightGreen;
            label1.Location = new Point(69, 26);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Projeto\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightGreen;
            label2.Location = new Point(69, 86);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(39, 39, 58);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.LightGreen;
            button1.Location = new Point(226, 321);
            button1.Name = "button1";
            button1.Size = new Size(113, 30);
            button1.TabIndex = 3;
            button1.Text = "Criar Projeto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tb_desc
            // 
            tb_desc.BackColor = Color.FromArgb(39, 39, 58);
            tb_desc.BorderStyle = BorderStyle.FixedSingle;
            tb_desc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_desc.ForeColor = Color.White;
            tb_desc.Location = new Point(69, 104);
            tb_desc.Multiline = true;
            tb_desc.Name = "tb_desc";
            tb_desc.Size = new Size(270, 197);
            tb_desc.TabIndex = 4;
            tb_desc.Text = "\r\n";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(39, 39, 58);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.LightGreen;
            button2.Location = new Point(69, 321);
            button2.Name = "button2";
            button2.Size = new Size(113, 30);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Criar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(401, 378);
            Controls.Add(button2);
            Controls.Add(tb_desc);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_nome);
            Name = "Criar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Criar Projeto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_nome;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox tb_desc;
        private Button button2;
    }
}