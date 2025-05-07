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
            labelErro = new Label();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClienteCadastrado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Cursor = Cursors.AppStarting;
            buttonCadastrar.Location = new Point(274, 234);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(99, 25);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // textBoxNome
            // 
            textBoxNome.Cursor = Cursors.IBeam;
            textBoxNome.Location = new Point(12, 94);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(241, 23);
            textBoxNome.TabIndex = 1;
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Cursor = Cursors.IBeam;
            maskedTextBoxTel.Location = new Point(12, 156);
            maskedTextBoxTel.Mask = "(00)00000-0000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(113, 23);
            maskedTextBoxTel.TabIndex = 3;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Cursor = Cursors.IBeam;
            maskedTextBoxCPF.Location = new Point(274, 156);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(112, 23);
            maskedTextBoxCPF.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Cursor = Cursors.IBeam;
            textBoxEmail.Location = new Point(274, 94);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(241, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.Transparent;
            labelNome.Location = new Point(11, 78);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(46, 15);
            labelNome.TabIndex = 6;
            labelNome.Text = " Nome:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Location = new Point(274, 78);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(52, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "* E-mail:";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.BackColor = Color.Transparent;
            labelCPF.Location = new Point(274, 131);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(39, 15);
            labelCPF.TabIndex = 8;
            labelCPF.Text = "* CPF:";
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.BackColor = Color.Transparent;
            labelTel.Location = new Point(11, 131);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(65, 15);
            labelTel.TabIndex = 9;
            labelTel.Text = " * Telefone:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.BorderStyle = BorderStyle.FixedSingle;
            labelTitulo.Font = new Font("Elephant", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(136, 28);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(265, 33);
            labelTitulo.TabIndex = 10;
            labelTitulo.Text = "Cadastro de Clientes";
            // 
            // button1
            // 
            button1.Cursor = Cursors.AppStarting;
            button1.Location = new Point(154, 234);
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
            dataGridViewClienteCadastrado.Location = new Point(11, 285);
            dataGridViewClienteCadastrado.Name = "dataGridViewClienteCadastrado";
            dataGridViewClienteCadastrado.Size = new Size(504, 240);
            dataGridViewClienteCadastrado.TabIndex = 14;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(100, 193);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(10, 15);
            labelErro.TabIndex = 16;
            labelErro.Text = ".";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(521, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 323);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(601, 502);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(245, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(848, 529);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxEmail);
            Controls.Add(dataGridViewClienteCadastrado);
            Controls.Add(pictureBox1);
            Controls.Add(labelNome);
            Controls.Add(labelErro);
            Controls.Add(labelTel);
            Controls.Add(maskedTextBoxTel);
            Controls.Add(button1);
            Controls.Add(labelTitulo);
            Controls.Add(labelCPF);
            Controls.Add(labelEmail);
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
        private Label labelErro;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
    }
}
