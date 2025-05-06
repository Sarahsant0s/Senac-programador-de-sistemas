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
            dataGridViewClienteCadastrado = new DataGridView();
            pictureBox1 = new PictureBox();
            labelErro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClienteCadastrado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(41, 287);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(99, 25);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 94);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(266, 23);
            textBoxNome.TabIndex = 1;
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Location = new Point(178, 235);
            maskedTextBoxTel.Mask = "(00)00000-0000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(100, 23);
            maskedTextBoxTel.TabIndex = 3;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(11, 235);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(100, 23);
            maskedTextBoxCPF.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 161);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(266, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 76);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(51, 15);
            labelNome.TabIndex = 6;
            labelNome.Text = "* Nome:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(11, 143);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(52, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "* E-mail:";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(11, 217);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(39, 15);
            labelCPF.TabIndex = 8;
            labelCPF.Text = "* CPF:";
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Location = new Point(172, 217);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(65, 15);
            labelTel.TabIndex = 9;
            labelTel.Text = " * Telefone:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Bell MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(21, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(216, 27);
            labelTitulo.TabIndex = 10;
            labelTitulo.Text = "Cadastro de Clientes";
            // 
            // button1
            // 
            button1.Location = new Point(157, 287);
            button1.Name = "button1";
            button1.Size = new Size(99, 25);
            button1.TabIndex = 12;
            button1.Text = "Próximo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewClienteCadastrado
            // 
            dataGridViewClienteCadastrado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClienteCadastrado.Location = new Point(331, 21);
            dataGridViewClienteCadastrado.Name = "dataGridViewClienteCadastrado";
            dataGridViewClienteCadastrado.Size = new Size(483, 282);
            dataGridViewClienteCadastrado.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-55, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(21, 318);
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
            ClientSize = new Size(862, 561);
            Controls.Add(labelErro);
            Controls.Add(textBoxEmail);
            Controls.Add(labelTel);
            Controls.Add(maskedTextBoxTel);
            Controls.Add(dataGridViewClienteCadastrado);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewClienteCadastrado).EndInit();
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
        private DataGridView dataGridViewClienteCadastrado;
        private PictureBox pictureBox1;
        private Label labelErro;
    }
}
