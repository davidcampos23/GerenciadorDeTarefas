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
            Voltar = new Button();
            Começar = new Label();
            Conclusão = new Label();
            Fazendo = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            CriarT = new Button();
            ExcluirT = new Button();
            label7 = new Label();
            panelMenu = new Panel();
            panelTarefas = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // Tarefas
            // 
            Tarefas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Tarefas.AutoSize = true;
            Tarefas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Tarefas.ForeColor = Color.LightGreen;
            Tarefas.Location = new Point(472, 121);
            Tarefas.Name = "Tarefas";
            Tarefas.Size = new Size(71, 25);
            Tarefas.TabIndex = 0;
            Tarefas.Text = "Tarefas";
            // 
            // nomeDoProjeto
            // 
            nomeDoProjeto.AutoSize = true;
            nomeDoProjeto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nomeDoProjeto.ForeColor = Color.LightGreen;
            nomeDoProjeto.Location = new Point(12, 26);
            nomeDoProjeto.Name = "nomeDoProjeto";
            nomeDoProjeto.Size = new Size(90, 32);
            nomeDoProjeto.TabIndex = 2;
            nomeDoProjeto.Text = "Projeto";
            // 
            // Voltar
            // 
            Voltar.Dock = DockStyle.Right;
            Voltar.FlatAppearance.BorderSize = 0;
            Voltar.FlatStyle = FlatStyle.Flat;
            Voltar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Voltar.ForeColor = Color.LightGreen;
            Voltar.Location = new Point(889, 0);
            Voltar.Name = "Voltar";
            Voltar.Size = new Size(117, 87);
            Voltar.TabIndex = 3;
            Voltar.Text = "Voltar";
            Voltar.UseVisualStyleBackColor = true;
            Voltar.Click += voltar_Click;
            // 
            // Começar
            // 
            Começar.Anchor = AnchorStyles.Left;
            Começar.AutoSize = true;
            Começar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Começar.ForeColor = Color.LightGreen;
            Começar.Location = new Point(132, 179);
            Começar.Name = "Começar";
            Começar.Size = new Size(72, 21);
            Começar.TabIndex = 4;
            Começar.Text = "Começar";
            // 
            // Conclusão
            // 
            Conclusão.Anchor = AnchorStyles.Right;
            Conclusão.AutoSize = true;
            Conclusão.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Conclusão.ForeColor = Color.LightGreen;
            Conclusão.Location = new Point(796, 179);
            Conclusão.Name = "Conclusão";
            Conclusão.Size = new Size(80, 21);
            Conclusão.TabIndex = 5;
            Conclusão.Text = "Concluído";
            // 
            // Fazendo
            // 
            Fazendo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Fazendo.AutoSize = true;
            Fazendo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Fazendo.ForeColor = Color.LightGreen;
            Fazendo.Location = new Point(472, 179);
            Fazendo.Name = "Fazendo";
            Fazendo.Size = new Size(67, 21);
            Fazendo.TabIndex = 6;
            Fazendo.Text = "Fazendo";
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.Anchor = AnchorStyles.Left;
            panel1.AutoSize = true;
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
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Goldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(340, 203);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 316);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Right;
            panel3.AutoSize = true;
            panel3.BackColor = Color.LimeGreen;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(672, 203);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 316);
            panel3.TabIndex = 8;
            // 
            // CriarT
            // 
            CriarT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CriarT.BackColor = Color.FromArgb(39, 39, 58);
            CriarT.FlatAppearance.BorderSize = 0;
            CriarT.FlatStyle = FlatStyle.Flat;
            CriarT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CriarT.ForeColor = Color.LightGreen;
            CriarT.Location = new Point(12, 575);
            CriarT.Name = "CriarT";
            CriarT.Size = new Size(75, 30);
            CriarT.TabIndex = 9;
            CriarT.Text = "Criar";
            CriarT.UseVisualStyleBackColor = false;
            CriarT.Click += CriarT_Click;
            // 
            // ExcluirT
            // 
            ExcluirT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExcluirT.BackColor = Color.FromArgb(39, 39, 58);
            ExcluirT.FlatAppearance.BorderSize = 0;
            ExcluirT.FlatStyle = FlatStyle.Flat;
            ExcluirT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExcluirT.ForeColor = Color.LightGreen;
            ExcluirT.Location = new Point(12, 620);
            ExcluirT.Name = "ExcluirT";
            ExcluirT.Size = new Size(75, 30);
            ExcluirT.TabIndex = 10;
            ExcluirT.Text = "Excluir";
            ExcluirT.UseVisualStyleBackColor = false;
            ExcluirT.Click += ExcluirT_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.LightGreen;
            label7.Location = new Point(12, 542);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 11;
            label7.Text = "Gerenciar";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(39, 39, 58);
            panelMenu.Controls.Add(nomeDoProjeto);
            panelMenu.Controls.Add(Voltar);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1006, 87);
            panelMenu.TabIndex = 12;
            // 
            // panelTarefas
            // 
            panelTarefas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelTarefas.BackColor = Color.FromArgb(39, 39, 58);
            panelTarefas.Location = new Point(225, 542);
            panelTarefas.Name = "panelTarefas";
            panelTarefas.Size = new Size(769, 117);
            panelTarefas.TabIndex = 13;
            // 
            // Projeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(1006, 671);
            Controls.Add(panelTarefas);
            Controls.Add(panelMenu);
            Controls.Add(label7);
            Controls.Add(ExcluirT);
            Controls.Add(CriarT);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(Começar);
            Controls.Add(panel1);
            Controls.Add(Fazendo);
            Controls.Add(Conclusão);
            Controls.Add(Tarefas);
            Name = "Projeto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projeto";
            Load += Projeto_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tarefas;
        private Label nomeDoProjeto;
        private Button Voltar;
        private Label Começar;
        private Label Conclusão;
        private Label Fazendo;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button CriarT;
        private Button ExcluirT;
        private Label label7;
        private Panel panelMenu;
        private Panel panelTarefas;
    }
}