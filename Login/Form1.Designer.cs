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
            components = new System.ComponentModel.Container();
            textBoxUsuário = new TextBox();
            textBoxSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonEntrar = new Button();
            labelResultado = new Label();
            buttonCadastrar = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            NovoUsuario = new TextBox();
            novaSenha = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            labelNovoUsuario = new Label();
            SuspendLayout();
            // 
            // textBoxUsuário
            // 
            textBoxUsuário.Location = new Point(74, 64);
            textBoxUsuário.Name = "textBoxUsuário";
            textBoxUsuário.Size = new Size(145, 23);
            textBoxUsuário.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(74, 93);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(145, 23);
            textBoxSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 67);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = ": Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 96);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(11, 132);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 4;
            label3.Text = "Esqueceu sua senha?";
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(144, 128);
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
            labelResultado.Location = new Point(27, 177);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 6;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(355, 128);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 7;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 67);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 9;
            label4.Text = "Usuário:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(260, 96);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 10;
            label5.Text = "Senha: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(299, 25);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 12;
            label6.Text = "Novo Usuário";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(109, 25);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 13;
            label7.Text = "Login";
            // 
            // NovoUsuario
            // 
            NovoUsuario.Location = new Point(316, 64);
            NovoUsuario.Name = "NovoUsuario";
            NovoUsuario.Size = new Size(147, 23);
            NovoUsuario.TabIndex = 14;
            // 
            // novaSenha
            // 
            novaSenha.Location = new Point(316, 93);
            novaSenha.Name = "novaSenha";
            novaSenha.Size = new Size(147, 23);
            novaSenha.TabIndex = 15;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // labelNovoUsuario
            // 
            labelNovoUsuario.AutoSize = true;
            labelNovoUsuario.Location = new Point(316, 177);
            labelNovoUsuario.Name = "labelNovoUsuario";
            labelNovoUsuario.Size = new Size(0, 15);
            labelNovoUsuario.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(889, 313);
            Controls.Add(labelNovoUsuario);
            Controls.Add(novaSenha);
            Controls.Add(NovoUsuario);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonCadastrar);
            Controls.Add(labelResultado);
            Controls.Add(buttonEntrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuário);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "login :)";
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
        private Button buttonCadastrar;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox NovoUsuario;
        private TextBox novaSenha;
        private NotifyIcon notifyIcon1;
        private Label labelNovoUsuario;
    }
}
