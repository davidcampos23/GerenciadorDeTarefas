namespace GerenciadorDeTarefas
{
    partial class Projeto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            CriarT = new Button();
            ExcluirT = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(472, 123);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Tarefas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 107);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.MouseDown += label2_MouseDown;
            label2.MouseMove += label2_MouseMove;
            label2.MouseUp += label2_MouseUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 21);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 2;
            label3.Text = "Projeto";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(877, 17);
            button1.Name = "button1";
            button1.Size = new Size(117, 34);
            button1.TabIndex = 3;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(132, 179);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 4;
            label4.Text = "Começar";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(796, 179);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 5;
            label5.Text = "Concluído";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(472, 179);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 6;
            label6.Text = "Fazendo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 203);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 316);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(340, 203);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 316);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LimeGreen;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(672, 203);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 316);
            panel3.TabIndex = 8;
            // 
            // CriarT
            // 
            CriarT.Location = new Point(12, 576);
            CriarT.Name = "CriarT";
            CriarT.Size = new Size(75, 23);
            CriarT.TabIndex = 9;
            CriarT.Text = "Criar";
            CriarT.UseVisualStyleBackColor = true;
            CriarT.Click += CriarT_Click;
            // 
            // ExcluirT
            // 
            ExcluirT.Location = new Point(12, 605);
            ExcluirT.Name = "ExcluirT";
            ExcluirT.Size = new Size(75, 23);
            ExcluirT.TabIndex = 10;
            ExcluirT.Text = "Excluir";
            ExcluirT.UseVisualStyleBackColor = true;
            ExcluirT.Click += ExcluirT_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 542);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 11;
            label7.Text = "Gerenciar";
            // 
            // Projeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 671);
            Controls.Add(label7);
            Controls.Add(ExcluirT);
            Controls.Add(CriarT);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Projeto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projeto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button CriarT;
        private Button ExcluirT;
        private Label label7;
    }
}