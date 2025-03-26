namespace Cadastro_Cliente
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
            labelinformações = new Label();
            textBoxnome = new TextBox();
            maskedTextBoxnascimento = new MaskedTextBox();
            maskedTextBoxtelefone = new MaskedTextBox();
            textBoxemail = new TextBox();
            comboBoxGenero = new ComboBox();
            textBoxnomesocial = new TextBox();
            comboBoxEtnia = new ComboBox();
            checkBoxsim = new CheckBox();
            radioButtonPJ = new RadioButton();
            radioButtonPF = new RadioButton();
            checkBoxTermo = new CheckBox();
            labelNome = new Label();
            labelNascimento = new Label();
            labelCel = new Label();
            labelGenero = new Label();
            labelEmail = new Label();
            labelnomesocial = new Label();
            labelEtinia = new Label();
            labelEstrangeiro = new Label();
            labelPFPJ = new Label();
            labelEndereco = new Label();
            textBoxLogradouro = new TextBox();
            textBoxnumero = new TextBox();
            textBoxcomplemento = new TextBox();
            textBoxbairro = new TextBox();
            textBoxmunicipio = new TextBox();
            comboBoxestado = new ComboBox();
            maskedTextBoxCep = new MaskedTextBox();
            label2 = new Label();
            labelnumero = new Label();
            label1 = new Label();
            labelbairro = new Label();
            labelmunicipio = new Label();
            labelcep = new Label();
            labelestado = new Label();
            buttonCadastrar = new Button();
            dataGridViewClientes = new DataGridView();
            labelErro = new Label();
            labelResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // labelinformações
            // 
            labelinformações.AutoSize = true;
            labelinformações.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelinformações.Location = new Point(36, 9);
            labelinformações.Name = "labelinformações";
            labelinformações.Size = new Size(181, 25);
            labelinformações.TabIndex = 0;
            labelinformações.Text = "Cadastre seu perfil:";
            // 
            // textBoxnome
            // 
            textBoxnome.Location = new Point(36, 62);
            textBoxnome.Name = "textBoxnome";
            textBoxnome.Size = new Size(100, 23);
            textBoxnome.TabIndex = 1;
            // 
            // maskedTextBoxnascimento
            // 
            maskedTextBoxnascimento.Location = new Point(36, 175);
            maskedTextBoxnascimento.Mask = "00/00/0000";
            maskedTextBoxnascimento.Name = "maskedTextBoxnascimento";
            maskedTextBoxnascimento.Size = new Size(100, 23);
            maskedTextBoxnascimento.TabIndex = 2;
            maskedTextBoxnascimento.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxtelefone
            // 
            maskedTextBoxtelefone.Location = new Point(36, 231);
            maskedTextBoxtelefone.Mask = "(99) 00000-0000";
            maskedTextBoxtelefone.Name = "maskedTextBoxtelefone";
            maskedTextBoxtelefone.Size = new Size(100, 23);
            maskedTextBoxtelefone.TabIndex = 3;
            // 
            // textBoxemail
            // 
            textBoxemail.Location = new Point(36, 289);
            textBoxemail.Name = "textBoxemail";
            textBoxemail.Size = new Size(100, 23);
            textBoxemail.TabIndex = 4;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Masculino", "Feminino ", "Não binário", "Prefiro não opinar" });
            comboBoxGenero.Location = new Point(36, 343);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(100, 23);
            comboBoxGenero.TabIndex = 5;
            // 
            // textBoxnomesocial
            // 
            textBoxnomesocial.Location = new Point(36, 118);
            textBoxnomesocial.Name = "textBoxnomesocial";
            textBoxnomesocial.Size = new Size(100, 23);
            textBoxnomesocial.TabIndex = 6;
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Items.AddRange(new object[] { "Branco", "Amarelo", "Pardo", "Negro", "Indígena" });
            comboBoxEtnia.Location = new Point(36, 404);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(100, 23);
            comboBoxEtnia.TabIndex = 7;
            // 
            // checkBoxsim
            // 
            checkBoxsim.AutoSize = true;
            checkBoxsim.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxsim.Location = new Point(36, 471);
            checkBoxsim.Name = "checkBoxsim";
            checkBoxsim.Size = new Size(48, 21);
            checkBoxsim.TabIndex = 8;
            checkBoxsim.Text = "Sim";
            checkBoxsim.UseVisualStyleBackColor = true;
            // 
            // radioButtonPJ
            // 
            radioButtonPJ.AutoSize = true;
            radioButtonPJ.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonPJ.Location = new Point(36, 549);
            radioButtonPJ.Name = "radioButtonPJ";
            radioButtonPJ.Size = new Size(115, 21);
            radioButtonPJ.TabIndex = 9;
            radioButtonPJ.TabStop = true;
            radioButtonPJ.Text = "Pessoa Jurídica";
            radioButtonPJ.UseVisualStyleBackColor = true;
            // 
            // radioButtonPF
            // 
            radioButtonPF.AutoSize = true;
            radioButtonPF.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonPF.Location = new Point(36, 528);
            radioButtonPF.Name = "radioButtonPF";
            radioButtonPF.Size = new Size(102, 21);
            radioButtonPF.TabIndex = 10;
            radioButtonPF.TabStop = true;
            radioButtonPF.Text = "Pessoa Física";
            radioButtonPF.UseVisualStyleBackColor = true;
            // 
            // checkBoxTermo
            // 
            checkBoxTermo.AutoSize = true;
            checkBoxTermo.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxTermo.Location = new Point(33, 585);
            checkBoxTermo.Name = "checkBoxTermo";
            checkBoxTermo.Size = new Size(379, 21);
            checkBoxTermo.TabIndex = 11;
            checkBoxTermo.Text = "Eu aceito os Termos e condições da política de privacidade.";
            checkBoxTermo.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(36, 44);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(56, 17);
            labelNome.TabIndex = 12;
            labelNome.Text = "* Nome:";
            // 
            // labelNascimento
            // 
            labelNascimento.AutoSize = true;
            labelNascimento.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNascimento.Location = new Point(34, 155);
            labelNascimento.Name = "labelNascimento";
            labelNascimento.Size = new Size(139, 17);
            labelNascimento.TabIndex = 13;
            labelNascimento.Text = "* Data de Nascimento:";
            // 
            // labelCel
            // 
            labelCel.AutoSize = true;
            labelCel.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCel.Location = new Point(36, 213);
            labelCel.Name = "labelCel";
            labelCel.Size = new Size(55, 15);
            labelCel.TabIndex = 14;
            labelCel.Text = "* Celular:";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGenero.Location = new Point(34, 324);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(63, 17);
            labelGenero.TabIndex = 15;
            labelGenero.Text = "* Gênero:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(36, 271);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 17);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "* Email:";
            // 
            // labelnomesocial
            // 
            labelnomesocial.AutoSize = true;
            labelnomesocial.Location = new Point(34, 100);
            labelnomesocial.Name = "labelnomesocial";
            labelnomesocial.Size = new Size(76, 15);
            labelnomesocial.TabIndex = 17;
            labelnomesocial.Text = "Nome social:";
            // 
            // labelEtinia
            // 
            labelEtinia.AutoSize = true;
            labelEtinia.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEtinia.Location = new Point(36, 384);
            labelEtinia.Name = "labelEtinia";
            labelEtinia.Size = new Size(48, 17);
            labelEtinia.TabIndex = 18;
            labelEtinia.Text = "* Etnia:";
            // 
            // labelEstrangeiro
            // 
            labelEstrangeiro.AutoSize = true;
            labelEstrangeiro.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEstrangeiro.Location = new Point(33, 451);
            labelEstrangeiro.Name = "labelEstrangeiro";
            labelEstrangeiro.Size = new Size(105, 17);
            labelEstrangeiro.TabIndex = 19;
            labelEstrangeiro.Text = "* Estrangeiro(a)?";
            // 
            // labelPFPJ
            // 
            labelPFPJ.AutoSize = true;
            labelPFPJ.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPFPJ.Location = new Point(33, 510);
            labelPFPJ.Name = "labelPFPJ";
            labelPFPJ.Size = new Size(108, 17);
            labelPFPJ.TabIndex = 21;
            labelPFPJ.Text = "* Tipo de Cliente:";
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEndereco.Location = new Point(405, 9);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(100, 25);
            labelEndereco.TabIndex = 22;
            labelEndereco.Text = "Endereço:";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(405, 62);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(178, 23);
            textBoxLogradouro.TabIndex = 23;
            // 
            // textBoxnumero
            // 
            textBoxnumero.Location = new Point(405, 118);
            textBoxnumero.Name = "textBoxnumero";
            textBoxnumero.Size = new Size(81, 23);
            textBoxnumero.TabIndex = 24;
            // 
            // textBoxcomplemento
            // 
            textBoxcomplemento.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxcomplemento.Location = new Point(405, 175);
            textBoxcomplemento.Name = "textBoxcomplemento";
            textBoxcomplemento.Size = new Size(178, 25);
            textBoxcomplemento.TabIndex = 25;
            // 
            // textBoxbairro
            // 
            textBoxbairro.Location = new Point(405, 231);
            textBoxbairro.Name = "textBoxbairro";
            textBoxbairro.Size = new Size(178, 23);
            textBoxbairro.TabIndex = 26;
            // 
            // textBoxmunicipio
            // 
            textBoxmunicipio.Location = new Point(405, 291);
            textBoxmunicipio.Name = "textBoxmunicipio";
            textBoxmunicipio.Size = new Size(81, 23);
            textBoxmunicipio.TabIndex = 27;
            // 
            // comboBoxestado
            // 
            comboBoxestado.FormattingEnabled = true;
            comboBoxestado.Items.AddRange(new object[] { "Acre – AC;", "Alagoas – AL;", "Amapá – AP;", "Amazonas – AM;", "Bahia – BA;", "Ceará – CE;", "Distrito Federal – DF;", "Espírito Santo – ES;", "Goiás – GO;", "Maranhão – MA;", "Mato Grosso – MT;", "Mato Grosso do Sul – MS;", "Minas Gerais – MG;", "Pará – PA;", "Paraíba – PB;", "Paraná – PR;", "Pernambuco – PE;", "Piauí – PI;", "Rio de Janeiro – RJ;", "Rio Grande do Norte – RN;", "Rio Grande do Sul – RS;", "Rondônia – RO;", "Roraima – RR;", "Santa Catarina – SC;", "São Paulo – SP;", "Sergipe – SE;", "Tocantins – TO." });
            comboBoxestado.Location = new Point(405, 343);
            comboBoxestado.Name = "comboBoxestado";
            comboBoxestado.Size = new Size(178, 23);
            comboBoxestado.TabIndex = 28;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(405, 404);
            maskedTextBoxCep.Mask = "00000-999";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(81, 23);
            maskedTextBoxCep.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(405, 44);
            label2.Name = "label2";
            label2.Size = new Size(90, 17);
            label2.TabIndex = 30;
            label2.Text = "* Logradouro:";
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnumero.Location = new Point(405, 98);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(68, 17);
            labelnumero.TabIndex = 31;
            labelnumero.Text = "* Número:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(405, 155);
            label1.Name = "label1";
            label1.Size = new Size(93, 17);
            label1.TabIndex = 32;
            label1.Text = "Complemento:";
            // 
            // labelbairro
            // 
            labelbairro.AutoSize = true;
            labelbairro.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelbairro.Location = new Point(405, 211);
            labelbairro.Name = "labelbairro";
            labelbairro.Size = new Size(55, 17);
            labelbairro.TabIndex = 33;
            labelbairro.Text = "* Bairro:";
            // 
            // labelmunicipio
            // 
            labelmunicipio.AutoSize = true;
            labelmunicipio.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelmunicipio.Location = new Point(405, 271);
            labelmunicipio.Name = "labelmunicipio";
            labelmunicipio.Size = new Size(77, 17);
            labelmunicipio.TabIndex = 34;
            labelmunicipio.Text = "* Município:";
            // 
            // labelcep
            // 
            labelcep.AutoSize = true;
            labelcep.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcep.Location = new Point(405, 384);
            labelcep.Name = "labelcep";
            labelcep.Size = new Size(45, 17);
            labelcep.TabIndex = 35;
            labelcep.Text = "* C.E.P";
            // 
            // labelestado
            // 
            labelestado.AutoSize = true;
            labelestado.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelestado.Location = new Point(405, 324);
            labelestado.Name = "labelestado";
            labelestado.Size = new Size(60, 17);
            labelestado.TabIndex = 36;
            labelestado.Text = "* Estado:";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrar.Location = new Point(405, 448);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(94, 23);
            buttonCadastrar.TabIndex = 37;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click_1;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.AllowUserToOrderColumns = true;
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(658, 84);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.Size = new Size(426, 317);
            dataGridViewClientes.TabIndex = 3;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(405, 494);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 41;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(405, 534);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 42;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 712);
            Controls.Add(labelResultado);
            Controls.Add(labelErro);
            Controls.Add(dataGridViewClientes);
            Controls.Add(buttonCadastrar);
            Controls.Add(labelestado);
            Controls.Add(labelcep);
            Controls.Add(labelmunicipio);
            Controls.Add(labelbairro);
            Controls.Add(label1);
            Controls.Add(labelnumero);
            Controls.Add(label2);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(comboBoxestado);
            Controls.Add(textBoxmunicipio);
            Controls.Add(textBoxbairro);
            Controls.Add(textBoxcomplemento);
            Controls.Add(textBoxnumero);
            Controls.Add(textBoxLogradouro);
            Controls.Add(labelEndereco);
            Controls.Add(labelPFPJ);
            Controls.Add(labelEstrangeiro);
            Controls.Add(labelEtinia);
            Controls.Add(labelnomesocial);
            Controls.Add(labelEmail);
            Controls.Add(labelGenero);
            Controls.Add(labelCel);
            Controls.Add(labelNascimento);
            Controls.Add(labelNome);
            Controls.Add(checkBoxTermo);
            Controls.Add(radioButtonPF);
            Controls.Add(radioButtonPJ);
            Controls.Add(checkBoxsim);
            Controls.Add(comboBoxEtnia);
            Controls.Add(textBoxnomesocial);
            Controls.Add(comboBoxGenero);
            Controls.Add(textBoxemail);
            Controls.Add(maskedTextBoxtelefone);
            Controls.Add(maskedTextBoxnascimento);
            Controls.Add(textBoxnome);
            Controls.Add(labelinformações);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelinformações;
        private TextBox textBoxnome;
        private MaskedTextBox maskedTextBoxnascimento;
        private MaskedTextBox maskedTextBoxtelefone;
        private TextBox textBoxemail;
        private ComboBox comboBoxGenero;
        private TextBox textBoxnomesocial;
        private ComboBox comboBoxEtnia;
        private CheckBox checkBoxsim;
        private RadioButton radioButtonPJ;
        private RadioButton radioButtonPF;
        private CheckBox checkBoxTermo;
        private Label labelNome;
        private Label labelNascimento;
        private Label labelCel;
        private Label labelGenero;
        private Label labelEmail;
        private Label labelnomesocial;
        private Label labelEtinia;
        private Label labelEstrangeiro;
        private Label labelPFPJ;
        private Label labelEndereco;
        private TextBox textBoxLogradouro;
        private TextBox textBoxnumero;
        private TextBox textBoxcomplemento;
        private TextBox textBoxbairro;
        private TextBox textBoxmunicipio;
        private ComboBox comboBoxestado;
        private MaskedTextBox maskedTextBoxCep;
        private Label label2;
        private Label labelnumero;
        private Label label1;
        private Label labelbairro;
        private Label labelmunicipio;
        private Label labelcep;
        private Label labelestado;
        private Button buttonCadastrar;
        private DataGridView dataGridViewClientes;
        private Label labelErro;
        private Label labelResultado;
    }
}
