namespace Projeto_Integrador
{
    partial class Fiscalização_dos_Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fiscalização_dos_Pedidos));
            tabPage2 = new TabPage();
            dateTimePicker1 = new DateTimePicker();
            pictureBox2 = new PictureBox();
            labelTitulo = new Label();
            groupBox1 = new GroupBox();
            labelNome = new Label();
            labelErro = new Label();
            buttonEfetuarPag = new Button();
            maskedTextBox1 = new MaskedTextBox();
            textBoxBuscarCliente = new TextBox();
            labelCPFCliente = new Label();
            labelIdPedido = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dateTimePicker2 = new DateTimePicker();
            groupBox2 = new GroupBox();
            dataGridViewClienteCadastrado = new DataGridView();
            groupBoxInformacoesPessoais = new GroupBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            textBoxNome = new TextBox();
            maskedTextBoxCPF = new MaskedTextBox();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            buttonCadastrar = new Button();
            label3 = new Label();
            labelCPF = new Label();
            button2 = new Button();
            maskedTextBoxTel = new MaskedTextBox();
            labelTel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClienteCadastrado).BeginInit();
            groupBoxInformacoesPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(labelTitulo);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(949, 587);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pedido";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(695, 556);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-13, 293);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(413, 256);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Elephant", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(3, 3);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(318, 35);
            labelTitulo.TabIndex = 4;
            labelTitulo.Text = "Pedidos em Pendência";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelNome);
            groupBox1.Controls.Add(labelErro);
            groupBox1.Controls.Add(buttonEfetuarPag);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(textBoxBuscarCliente);
            groupBox1.Controls.Add(labelCPFCliente);
            groupBox1.Controls.Add(labelIdPedido);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(6, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 250);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = SystemColors.ButtonFace;
            labelNome.Location = new Point(6, 40);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(173, 15);
            labelNome.TabIndex = 11;
            labelNome.Text = "Nome e Sobrenome do Cliente:";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.BackColor = SystemColors.Control;
            labelErro.Location = new Point(20, 168);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(10, 15);
            labelErro.TabIndex = 8;
            labelErro.Text = ".";
            // 
            // buttonEfetuarPag
            // 
            buttonEfetuarPag.Location = new Point(60, 210);
            buttonEfetuarPag.Name = "buttonEfetuarPag";
            buttonEfetuarPag.Size = new Size(175, 23);
            buttonEfetuarPag.TabIndex = 9;
            buttonEfetuarPag.Text = "Efetuar Pagamento agora";
            buttonEfetuarPag.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(135, 123);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 5;
            // 
            // textBoxBuscarCliente
            // 
            textBoxBuscarCliente.Location = new Point(6, 58);
            textBoxBuscarCliente.Name = "textBoxBuscarCliente";
            textBoxBuscarCliente.Size = new Size(261, 23);
            textBoxBuscarCliente.TabIndex = 10;
            // 
            // labelCPFCliente
            // 
            labelCPFCliente.AutoSize = true;
            labelCPFCliente.BackColor = SystemColors.Control;
            labelCPFCliente.Location = new Point(135, 105);
            labelCPFCliente.Name = "labelCPFCliente";
            labelCPFCliente.Size = new Size(88, 15);
            labelCPFCliente.TabIndex = 4;
            labelCPFCliente.Text = "CPF do Cliente:";
            // 
            // labelIdPedido
            // 
            labelIdPedido.AutoSize = true;
            labelIdPedido.BackColor = SystemColors.ButtonFace;
            labelIdPedido.Location = new Point(6, 105);
            labelIdPedido.Name = "labelIdPedido";
            labelIdPedido.Size = new Size(77, 15);
            labelIdPedido.TabIndex = 3;
            labelIdPedido.Text = "Id do Pedido:";
            // 
            // button1
            // 
            button1.Location = new Point(87, 181);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 6;
            button1.Text = "Procurar Pedido";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(957, 618);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBoxInformacoesPessoais);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(949, 587);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = SystemColors.ScrollBar;
            dateTimePicker2.Location = new Point(698, 558);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(245, 23);
            dateTimePicker2.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewClienteCadastrado);
            groupBox2.Location = new Point(439, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(507, 293);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Observações";
            // 
            // dataGridViewClienteCadastrado
            // 
            dataGridViewClienteCadastrado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClienteCadastrado.Location = new Point(9, 22);
            dataGridViewClienteCadastrado.Name = "dataGridViewClienteCadastrado";
            dataGridViewClienteCadastrado.Size = new Size(489, 257);
            dataGridViewClienteCadastrado.TabIndex = 14;
            // 
            // groupBoxInformacoesPessoais
            // 
            groupBoxInformacoesPessoais.BackColor = Color.Transparent;
            groupBoxInformacoesPessoais.Controls.Add(pictureBox3);
            groupBoxInformacoesPessoais.Controls.Add(label2);
            groupBoxInformacoesPessoais.Controls.Add(pictureBox4);
            groupBoxInformacoesPessoais.Controls.Add(textBoxNome);
            groupBoxInformacoesPessoais.Controls.Add(maskedTextBoxCPF);
            groupBoxInformacoesPessoais.Controls.Add(textBoxEmail);
            groupBoxInformacoesPessoais.Controls.Add(labelEmail);
            groupBoxInformacoesPessoais.Controls.Add(buttonCadastrar);
            groupBoxInformacoesPessoais.Controls.Add(label3);
            groupBoxInformacoesPessoais.Controls.Add(labelCPF);
            groupBoxInformacoesPessoais.Controls.Add(button2);
            groupBoxInformacoesPessoais.Controls.Add(maskedTextBoxTel);
            groupBoxInformacoesPessoais.Controls.Add(labelTel);
            groupBoxInformacoesPessoais.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxInformacoesPessoais.ForeColor = SystemColors.ActiveCaptionText;
            groupBoxInformacoesPessoais.Location = new Point(15, 37);
            groupBoxInformacoesPessoais.Name = "groupBoxInformacoesPessoais";
            groupBoxInformacoesPessoais.Size = new Size(418, 293);
            groupBoxInformacoesPessoais.TabIndex = 23;
            groupBoxInformacoesPessoais.TabStop = false;
            groupBoxInformacoesPessoais.Text = "Informações Pessoais";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(20, 53);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 61);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 6;
            label2.Text = "Nome";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(260, 53);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // textBoxNome
            // 
            textBoxNome.Cursor = Cursors.IBeam;
            textBoxNome.Location = new Point(20, 81);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(217, 25);
            textBoxNome.TabIndex = 1;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Cursor = Cursors.IBeam;
            maskedTextBoxCPF.Location = new Point(259, 152);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(124, 25);
            maskedTextBoxCPF.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Cursor = Cursors.IBeam;
            textBoxEmail.Location = new Point(20, 152);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(217, 25);
            textBoxEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(20, 132);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 17);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "E-mail*";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = SystemColors.ActiveBorder;
            buttonCadastrar.BackgroundImageLayout = ImageLayout.None;
            buttonCadastrar.Cursor = Cursors.AppStarting;
            buttonCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCadastrar.Location = new Point(150, 221);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(118, 30);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 194);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 16;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.BackColor = Color.Transparent;
            labelCPF.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCPF.Location = new Point(259, 132);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(34, 17);
            labelCPF.TabIndex = 8;
            labelCPF.Text = "CPF*";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Cursor = Cursors.AppStarting;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(128, 257);
            button2.Name = "button2";
            button2.Size = new Size(162, 30);
            button2.TabIndex = 12;
            button2.Text = "Fazer Pedido";
            button2.UseVisualStyleBackColor = false;
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Cursor = Cursors.IBeam;
            maskedTextBoxTel.Location = new Point(260, 81);
            maskedTextBoxTel.Mask = "(00)00000-0000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(124, 25);
            maskedTextBoxTel.TabIndex = 3;
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.BackColor = Color.Transparent;
            labelTel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTel.Location = new Point(286, 61);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(57, 17);
            labelTel.TabIndex = 9;
            labelTel.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Elephant", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 3);
            label1.Name = "label1";
            label1.Size = new Size(263, 31);
            label1.TabIndex = 11;
            label1.Text = "Cadastro de Clientes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(242, 307);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 329);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Fiscalização_dos_Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(957, 616);
            Controls.Add(tabControl1);
            Name = "Fiscalização_dos_Pedidos";
            Text = "HairSharp";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClienteCadastrado).EndInit();
            groupBoxInformacoesPessoais.ResumeLayout(false);
            groupBoxInformacoesPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox2;
        private Label labelTitulo;
        private GroupBox groupBox1;
        private Label labelNome;
        private Label labelErro;
        private Button buttonEfetuarPag;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBoxBuscarCliente;
        private Label labelCPFCliente;
        private Label labelIdPedido;
        private Button button1;
        private TextBox textBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBoxInformacoesPessoais;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox4;
        private TextBox textBoxNome;
        private MaskedTextBox maskedTextBoxCPF;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Button buttonCadastrar;
        private Label label3;
        private Label labelCPF;
        private Button button2;
        private MaskedTextBox maskedTextBoxTel;
        private Label labelTel;
        private GroupBox groupBox2;
        private DataGridView dataGridViewClienteCadastrado;
        private DateTimePicker dateTimePicker2;
    }
}