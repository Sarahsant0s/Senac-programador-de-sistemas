namespace Projeto_Integrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonCadastrar = new Button();
            textBoxNome = new TextBox();
            maskedTextBoxTel = new MaskedTextBox();
            maskedTextBoxCPF = new MaskedTextBox();
            textBoxEmail = new TextBox();
            labelNome = new Label();
            labelEmail = new Label();
            labelCPF = new Label();
            labelTel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(370, 344);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(99, 25);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(316, 101);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(239, 23);
            textBoxNome.TabIndex = 1;
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Location = new Point(316, 291);
            maskedTextBoxTel.Mask = "(00)00000-0000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(100, 23);
            maskedTextBoxTel.TabIndex = 3;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(316, 226);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(100, 23);
            maskedTextBoxCPF.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(316, 165);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(239, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(316, 83);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 6;
            labelNome.Text = "Nome:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(316, 147);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "E-mail:";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(316, 208);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(31, 15);
            labelCPF.TabIndex = 8;
            labelCPF.Text = "CPF:";
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Location = new Point(316, 273);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(57, 15);
            labelTel.TabIndex = 9;
            labelTel.Text = " Telefone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 22);
            label1.Name = "label1";
            label1.Size = new Size(251, 29);
            label1.TabIndex = 10;
            label1.Text = "Cadastro de Clientes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(537, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Proxímo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(624, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(labelTel);
            Controls.Add(labelCPF);
            Controls.Add(labelEmail);
            Controls.Add(labelNome);
            Controls.Add(textBoxEmail);
            Controls.Add(maskedTextBoxCPF);
            Controls.Add(maskedTextBoxTel);
            Controls.Add(textBoxNome);
            Controls.Add(buttonCadastrar);
            Name = "Form1";
            Text = "Cadastre-se";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCadastrar;
        private TextBox textBoxNome;
        private MaskedTextBox maskedTextBoxTel;
        private MaskedTextBox maskedTextBoxCPF;
        private TextBox textBoxEmail;
        private Label labelNome;
        private Label labelEmail;
        private Label labelCPF;
        private Label labelTel;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
