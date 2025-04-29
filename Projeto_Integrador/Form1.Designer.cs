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
            button1 = new Button();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(152, 187);
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
            textBoxNome.Size = new Size(239, 23);
            textBoxNome.TabIndex = 1;
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Location = new Point(12, 241);
            maskedTextBoxTel.Mask = "(00)00000-0000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(100, 23);
            maskedTextBoxTel.TabIndex = 3;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(12, 176);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(100, 23);
            maskedTextBoxCPF.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 120);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(239, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 41);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 6;
            labelNome.Text = "Nome:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 102);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "E-mail:";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(12, 158);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(31, 15);
            labelCPF.TabIndex = 8;
            labelCPF.Text = "CPF:";
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Location = new Point(12, 218);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(57, 15);
            labelTel.TabIndex = 9;
            labelTel.Text = " Telefone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 27);
            label1.TabIndex = 10;
            label1.Text = "Cadastro de Clientes";
            // 
            // button1
            // 
            button1.Location = new Point(152, 239);
            button1.Name = "button1";
            button1.Size = new Size(99, 25);
            button1.TabIndex = 12;
            button1.Text = "Próximo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-58, 293);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(375, 199);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(578, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(530, 464);
            dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1120, 504);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
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
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Cadastre-se";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button button1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
    }
}
