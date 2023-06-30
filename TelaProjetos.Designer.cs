namespace GerenciadorDeTarefas
{
    partial class TelaProjetos
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
            CriarProj = new Button();
            ExcluirProj = new Button();
            panelMenu = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGreen;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 0;
            label1.Text = "Projetos";
            // 
            // CriarProj
            // 
            CriarProj.AutoSize = true;
            CriarProj.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CriarProj.BackColor = Color.FromArgb(39, 39, 58);
            CriarProj.Dock = DockStyle.Right;
            CriarProj.FlatAppearance.BorderSize = 0;
            CriarProj.FlatStyle = FlatStyle.Flat;
            CriarProj.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CriarProj.ForeColor = Color.LightGreen;
            CriarProj.Location = new Point(729, 0);
            CriarProj.Name = "CriarProj";
            CriarProj.Size = new Size(133, 87);
            CriarProj.TabIndex = 2;
            CriarProj.Text = "Novo Projeto";
            CriarProj.UseVisualStyleBackColor = false;
            CriarProj.Click += button1_Click;
            // 
            // ExcluirProj
            // 
            ExcluirProj.AutoSize = true;
            ExcluirProj.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ExcluirProj.BackColor = Color.FromArgb(39, 39, 58);
            ExcluirProj.Dock = DockStyle.Right;
            ExcluirProj.FlatAppearance.BorderSize = 0;
            ExcluirProj.FlatStyle = FlatStyle.Flat;
            ExcluirProj.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ExcluirProj.ForeColor = Color.LightGreen;
            ExcluirProj.Location = new Point(862, 0);
            ExcluirProj.Name = "ExcluirProj";
            ExcluirProj.Size = new Size(144, 87);
            ExcluirProj.TabIndex = 5;
            ExcluirProj.Text = "Excluir Projeto";
            ExcluirProj.UseVisualStyleBackColor = false;
            ExcluirProj.Click += ExcluirProj_Click;
            // 
            // panelMenu
            // 
            panelMenu.AutoSize = true;
            panelMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMenu.BackColor = Color.FromArgb(39, 39, 58);
            panelMenu.Controls.Add(CriarProj);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(ExcluirProj);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1006, 87);
            panelMenu.TabIndex = 6;
            // 
            // TelaProjetos
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(1006, 671);
            Controls.Add(panelMenu);
            Name = "TelaProjetos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaProjetos";
            Load += TelaProjetos_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CriarProj;
        private Button ExcluirProj;
        private Panel panelMenu;
    }
}