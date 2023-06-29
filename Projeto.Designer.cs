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
            Tarefas = new Label();
            nomeDoProjeto = new Label();
            button1 = new Button();
            Começar = new Label();
            Conclusão = new Label();
            Fazendo = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            CriarT = new Button();
            ExcluirT = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // Tarefas
            // 
            Tarefas.AutoSize = true;
            Tarefas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Tarefas.Location = new Point(472, 123);
            Tarefas.Name = "Tarefas";
            Tarefas.Size = new Size(71, 25);
            Tarefas.TabIndex = 0;
            Tarefas.Text = "Tarefas";
            // 
            // nomeDoProjeto
            // 
            nomeDoProjeto.AutoSize = true;
            nomeDoProjeto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nomeDoProjeto.Location = new Point(12, 21);
            nomeDoProjeto.Name = "nomeDoProjeto";
            nomeDoProjeto.Size = new Size(73, 25);
            nomeDoProjeto.TabIndex = 2;
            nomeDoProjeto.Text = "Projeto";
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
            // Começar
            // 
            Começar.AutoSize = true;
            Começar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Começar.Location = new Point(132, 179);
            Começar.Name = "Começar";
            Começar.Size = new Size(72, 21);
            Começar.TabIndex = 4;
            Começar.Text = "Começar";
            // 
            // Conclusão
            // 
            Conclusão.AutoSize = true;
            Conclusão.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Conclusão.Location = new Point(796, 179);
            Conclusão.Name = "Conclusão";
            Conclusão.Size = new Size(80, 21);
            Conclusão.TabIndex = 5;
            Conclusão.Text = "Concluído";
            // 
            // Fazendo
            // 
            Fazendo.AutoSize = true;
            Fazendo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Fazendo.Location = new Point(472, 179);
            Fazendo.Name = "Fazendo";
            Fazendo.Size = new Size(67, 21);
            Fazendo.TabIndex = 6;
            Fazendo.Text = "Fazendo";
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.IndianRed;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.CausesValidation = false;
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
            CriarT.Location = new Point(14, 567);
            CriarT.Name = "CriarT";
            CriarT.Size = new Size(75, 23);
            CriarT.TabIndex = 9;
            CriarT.Text = "Criar";
            CriarT.UseVisualStyleBackColor = true;
            CriarT.Click += CriarT_Click;
            // 
            // ExcluirT
            // 
            ExcluirT.Location = new Point(14, 612);
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
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(Começar);
            Controls.Add(panel1);
            Controls.Add(Fazendo);
            Controls.Add(Conclusão);
            Controls.Add(button1);
            Controls.Add(nomeDoProjeto);
            Controls.Add(Tarefas);
            Name = "Projeto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projeto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tarefas;
        private Label nomeDoProjeto;
        private Button button1;
        private Label Começar;
        private Label Conclusão;
        private Label Fazendo;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button CriarT;
        private Button ExcluirT;
        private Label label7;
    }
}