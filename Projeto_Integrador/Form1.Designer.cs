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
            labelTitulo = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            labelErro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(196, 172);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(99, 25);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 59);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(266, 23);
            textBoxNome.TabIndex = 1;
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Location = new Point(419, 117);
            maskedTextBoxTel.Mask = "(00)00000-0000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(100, 23);
            maskedTextBoxTel.TabIndex = 3;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(97, 117);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(100, 23);
            maskedTextBoxCPF.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(320, 59);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(266, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 41);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(51, 15);
            labelNome.TabIndex = 6;
            labelNome.Text = "* Nome:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(320, 41);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(52, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "* E-mail:";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(124, 99);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(39, 15);
            labelCPF.TabIndex = 8;
            labelCPF.Text = "* CPF:";
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Location = new Point(429, 99);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(65, 15);
            labelTel.TabIndex = 9;
            labelTel.Text = " * Telefone:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Bell MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(210, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(216, 27);
            labelTitulo.TabIndex = 10;
            labelTitulo.Text = "Cadastro de Clientes";
            // 
            // button1
            // 
            button1.Location = new Point(301, 172);
            button1.Name = "button1";
            button1.Size = new Size(99, 25);
            button1.TabIndex = 12;
            button1.Text = "Próximo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(574, 227);
            dataGridView1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(178, 418);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(226, 142);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(10, 15);
            labelErro.TabIndex = 16;
            labelErro.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(604, 535);
            Controls.Add(labelErro);
            Controls.Add(textBoxEmail);
            Controls.Add(labelTel);
            Controls.Add(maskedTextBoxTel);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(labelTitulo);
            Controls.Add(labelCPF);
            Controls.Add(labelEmail);
            Controls.Add(labelNome);
            Controls.Add(maskedTextBoxCPF);
            Controls.Add(textBoxNome);
            Controls.Add(buttonCadastrar);
            Name = "Form1";
            Text = "Cadastre-se";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label labelTitulo;
        private Button button1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label labelErro;
    }
}
