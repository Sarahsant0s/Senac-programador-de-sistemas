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
            groupBoxInformacoesPessoais = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClienteCadastrado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInformacoesPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = SystemColors.ControlDark;
            buttonCadastrar.BackgroundImageLayout = ImageLayout.None;
            buttonCadastrar.Cursor = Cursors.AppStarting;
            buttonCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCadastrar.Location = new Point(233, 212);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(138, 30);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = false;
            // 
            // textBoxNome
            // 
            textBoxNome.Cursor = Cursors.IBeam;
            textBoxNome.Location = new Point(28, 75);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(210, 25);
            textBoxNome.TabIndex = 1;
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Cursor = Cursors.IBeam;
            maskedTextBoxTel.Location = new Point(261, 75);
            maskedTextBoxTel.Mask = "(00)00000-0000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(124, 25);
            maskedTextBoxTel.TabIndex = 3;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Cursor = Cursors.IBeam;
            maskedTextBoxCPF.Location = new Point(261, 143);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(124, 25);
            maskedTextBoxCPF.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Cursor = Cursors.IBeam;
            textBoxEmail.Location = new Point(27, 143);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(211, 25);
            textBoxEmail.TabIndex = 5;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.Transparent;
            labelNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(58, 55);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(44, 17);
            labelNome.TabIndex = 6;
            labelNome.Text = "Nome";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(27, 123);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 17);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "E-mail*";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.BackColor = Color.Transparent;
            labelCPF.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCPF.Location = new Point(261, 123);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(34, 17);
            labelCPF.TabIndex = 8;
            labelCPF.Text = "CPF*";
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.BackColor = Color.Transparent;
            labelTel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTel.Location = new Point(287, 55);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(57, 17);
            labelTel.TabIndex = 9;
            labelTel.Text = "Telefone";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Elephant", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(305, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(263, 31);
            labelTitulo.TabIndex = 10;
            labelTitulo.Text = "Cadastro de Clientes";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Cursor = Cursors.AppStarting;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(80, 212);
            button1.Name = "button1";
            button1.Size = new Size(138, 30);
            button1.TabIndex = 12;
            button1.Text = "Próximo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewClienteCadastrado
            // 
            dataGridViewClienteCadastrado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClienteCadastrado.Location = new Point(9, 22);
            dataGridViewClienteCadastrado.Name = "dataGridViewClienteCadastrado";
            dataGridViewClienteCadastrado.Size = new Size(464, 257);
            dataGridViewClienteCadastrado.TabIndex = 14;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(80, 192);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(11, 17);
            labelErro.TabIndex = 16;
            labelErro.Text = ".";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(252, 306);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(417, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(689, 506);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(245, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // groupBoxInformacoesPessoais
            // 
            groupBoxInformacoesPessoais.BackColor = Color.Transparent;
            groupBoxInformacoesPessoais.Controls.Add(pictureBox2);
            groupBoxInformacoesPessoais.Controls.Add(labelNome);
            groupBoxInformacoesPessoais.Controls.Add(pictureBox3);
            groupBoxInformacoesPessoais.Controls.Add(textBoxNome);
            groupBoxInformacoesPessoais.Controls.Add(maskedTextBoxCPF);
            groupBoxInformacoesPessoais.Controls.Add(textBoxEmail);
            groupBoxInformacoesPessoais.Controls.Add(labelEmail);
            groupBoxInformacoesPessoais.Controls.Add(buttonCadastrar);
            groupBoxInformacoesPessoais.Controls.Add(labelErro);
            groupBoxInformacoesPessoais.Controls.Add(labelCPF);
            groupBoxInformacoesPessoais.Controls.Add(button1);
            groupBoxInformacoesPessoais.Controls.Add(maskedTextBoxTel);
            groupBoxInformacoesPessoais.Controls.Add(labelTel);
            groupBoxInformacoesPessoais.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxInformacoesPessoais.ForeColor = SystemColors.ActiveCaptionText;
            groupBoxInformacoesPessoais.Location = new Point(3, 43);
            groupBoxInformacoesPessoais.Name = "groupBoxInformacoesPessoais";
            groupBoxInformacoesPessoais.Size = new Size(446, 293);
            groupBoxInformacoesPessoais.TabIndex = 22;
            groupBoxInformacoesPessoais.TabStop = false;
            groupBoxInformacoesPessoais.Text = "Informações Pessoais";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(261, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewClienteCadastrado);
            groupBox1.Location = new Point(455, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 293);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Observações";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(937, 531);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxInformacoesPessoais);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(labelTitulo);
            Name = "Form1";
            Text = "Cadastre-se";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClienteCadastrado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxInformacoesPessoais.ResumeLayout(false);
            groupBoxInformacoesPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
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
        private GroupBox groupBoxInformacoesPessoais;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
    }
}
