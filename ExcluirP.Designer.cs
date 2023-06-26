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
            bCancelar.Location = new Point(35, 154);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(83, 23);
            bCancelar.TabIndex = 1;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = true;
            bCancelar.Click += bCancelar_Click;
            // 
            // bExcluir
            // 
            bExcluir.Location = new Point(134, 154);
            bExcluir.Name = "bExcluir";
            bExcluir.Size = new Size(83, 23);
            bExcluir.TabIndex = 2;
            bExcluir.Text = "Excluir";
            bExcluir.UseVisualStyleBackColor = true;
            bExcluir.Click += bExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 57);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "Excluir Projeto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 4;
            // 
            // ExcluirP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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