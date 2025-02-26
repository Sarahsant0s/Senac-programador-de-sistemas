namespace Login
{
    partial class Form1
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
            textBoxUsuário = new TextBox();
            textBoxSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonEntrar = new Button();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // textBoxUsuário
            // 
            textBoxUsuário.Location = new Point(286, 71);
            textBoxUsuário.Name = "textBoxUsuário";
            textBoxUsuário.Size = new Size(145, 23);
            textBoxUsuário.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(286, 126);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(145, 23);
            textBoxSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 74);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = ": Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 129);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(224, 178);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 4;
            label3.Text = "Esqueceu sua senha?";
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(356, 174);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(75, 23);
            buttonEntrar.TabIndex = 5;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += button1_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(224, 227);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 313);
            Controls.Add(labelResultado);
            Controls.Add(buttonEntrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuário);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuário;
        private TextBox textBoxSenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonEntrar;
        private Label labelResultado;
    }
}
