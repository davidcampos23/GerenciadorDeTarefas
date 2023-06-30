namespace GerenciadorDeTarefas
{
    partial class ExcluirP
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
            bCancelar = new Button();
            bExcluir = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // bCancelar
            // 
            bCancelar.BackColor = Color.FromArgb(39, 39, 58);
            bCancelar.FlatAppearance.BorderSize = 0;
            bCancelar.FlatStyle = FlatStyle.Flat;
            bCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bCancelar.ForeColor = Color.LightGreen;
            bCancelar.Location = new Point(35, 154);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(83, 23);
            bCancelar.TabIndex = 1;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = false;
            bCancelar.Click += bCancelar_Click;
            // 
            // bExcluir
            // 
            bExcluir.BackColor = Color.FromArgb(39, 39, 58);
            bExcluir.FlatAppearance.BorderSize = 0;
            bExcluir.FlatStyle = FlatStyle.Flat;
            bExcluir.ForeColor = Color.LightGreen;
            bExcluir.Location = new Point(134, 154);
            bExcluir.Name = "bExcluir";
            bExcluir.Size = new Size(83, 23);
            bExcluir.TabIndex = 2;
            bExcluir.Text = "Excluir";
            bExcluir.UseVisualStyleBackColor = false;
            bExcluir.Click += bExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LightGreen;
            label1.Location = new Point(35, 63);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "Excluir Projeto";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(39, 39, 58);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(35, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 4;
            // 
            // ExcluirP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(256, 214);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(bExcluir);
            Controls.Add(bCancelar);
            Name = "ExcluirP";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ExcluirP";
            ResumeLayout(false);
            PerformLayout();
        }

        private void nome_proj_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button bCancelar;
        private Button bExcluir;
        private Label label1;
        private TextBox textBox1;
    }
}