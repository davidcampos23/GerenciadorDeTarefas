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
            SuspendLayout();
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(69, 44);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(175, 23);
            tb_nome.TabIndex = 0;
            tb_nome.Text = "\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
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
            label2.Location = new Point(69, 86);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // button1
            // 
            button1.Location = new Point(145, 324);
            button1.Name = "button1";
            button1.Size = new Size(113, 30);
            button1.TabIndex = 3;
            button1.Text = "Criar Projeto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tb_desc
            // 
            tb_desc.Location = new Point(69, 104);
            tb_desc.Multiline = true;
            tb_desc.Name = "tb_desc";
            tb_desc.Size = new Size(270, 197);
            tb_desc.TabIndex = 4;
            tb_desc.Text = "\r\n";
            // 
            // Criar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 378);
            Controls.Add(tb_desc);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_nome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Criar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_nome;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox tb_desc;
    }
}