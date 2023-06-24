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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Projetos";
            label1.Click += label1_Click;
            // 
            // CriarProj
            // 
            CriarProj.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CriarProj.Location = new Point(877, 17);
            CriarProj.Name = "CriarProj";
            CriarProj.Size = new Size(117, 34);
            CriarProj.TabIndex = 2;
            CriarProj.Text = "Novo Projeto";
            CriarProj.UseVisualStyleBackColor = true;
            CriarProj.Click += button1_Click;
            // 
            // ExcluirProj
            // 
            ExcluirProj.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExcluirProj.Location = new Point(721, 17);
            ExcluirProj.Name = "ExcluirProj";
            ExcluirProj.Size = new Size(117, 34);
            ExcluirProj.TabIndex = 5;
            ExcluirProj.Text = "Excluir Projeto";
            ExcluirProj.UseVisualStyleBackColor = true;
            // 
            // TelaProjetos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 671);
            Controls.Add(ExcluirProj);
            Controls.Add(CriarProj);
            Controls.Add(label1);
            Name = "TelaProjetos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaProjetos";
            Load += TelaProjetos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CriarProj;
        private Button ExcluirProj;
    }
}