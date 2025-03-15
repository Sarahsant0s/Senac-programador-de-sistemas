namespace Calculadora___2
{
    partial class radioButtonCompri
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
            labelTitulo1 = new Label();
            label1 = new Label();
            buttonCalcular = new Button();
            textBoxLargura = new TextBox();
            textBoxaltura = new TextBox();
            comboBoxFormas = new ComboBox();
            labelAltura = new Label();
            labelErro = new Label();
            groupBox1 = new GroupBox();
            textBoxResultado = new TextBox();
            textBoxCompri = new TextBox();
            label2 = new Label();
            labelcompri = new Label();
            labellargura = new Label();
            radioButtonVol = new RadioButton();
            radioButtonPerimetro = new RadioButton();
            radioButtonÁrea = new RadioButton();
            groupBox2 = new GroupBox();
            buttonCalcularQua = new Button();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            textBoxresultado2 = new TextBox();
            textBoxlado = new TextBox();
            labelresultado2 = new Label();
            labellado = new Label();
            buttonnovoform = new Button();
            groupBox3 = new GroupBox();
            button2 = new Button();
            label7 = new Label();
            textBoxResultadoCirculo = new TextBox();
            radioButtonvol3 = new RadioButton();
            radioButtonperi3 = new RadioButton();
            radioButtondiametro = new RadioButton();
            radioButtonarea3 = new RadioButton();
            labelRaio = new Label();
            textBoxRaio = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo1
            // 
            labelTitulo1.AutoSize = true;
            labelTitulo1.BackColor = SystemColors.ActiveCaption;
            labelTitulo1.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo1.Location = new Point(9, 47);
            labelTitulo1.Name = "labelTitulo1";
            labelTitulo1.Size = new Size(213, 18);
            labelTitulo1.TabIndex = 1;
            labelTitulo1.Text = "Selecione a Forma Geométrica:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 22);
            label1.TabIndex = 3;
            label1.Text = "CALCULE A FORMA";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCalcular.Location = new Point(301, 73);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 8;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // textBoxLargura
            // 
            textBoxLargura.Location = new Point(97, 91);
            textBoxLargura.Name = "textBoxLargura";
            textBoxLargura.Size = new Size(77, 23);
            textBoxLargura.TabIndex = 9;
            // 
            // textBoxaltura
            // 
            textBoxaltura.Location = new Point(97, 15);
            textBoxaltura.Name = "textBoxaltura";
            textBoxaltura.Size = new Size(77, 23);
            textBoxaltura.TabIndex = 10;
            // 
            // comboBoxFormas
            // 
            comboBoxFormas.FormattingEnabled = true;
            comboBoxFormas.Items.AddRange(new object[] { "Círculo", "Quadrado", "Retângulo" });
            comboBoxFormas.Location = new Point(9, 80);
            comboBoxFormas.Name = "comboBoxFormas";
            comboBoxFormas.Size = new Size(135, 23);
            comboBoxFormas.TabIndex = 11;
            comboBoxFormas.SelectedIndexChanged += comboBoxFormas_SelectedIndexChanged;
            // 
            // labelAltura
            // 
            labelAltura.AutoSize = true;
            labelAltura.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAltura.Location = new Point(0, 16);
            labelAltura.Name = "labelAltura";
            labelAltura.Size = new Size(52, 19);
            labelAltura.TabIndex = 14;
            labelAltura.Text = "Altura:";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(459, 262);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxResultado);
            groupBox1.Controls.Add(textBoxCompri);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labelcompri);
            groupBox1.Controls.Add(labellargura);
            groupBox1.Controls.Add(labelAltura);
            groupBox1.Controls.Add(radioButtonVol);
            groupBox1.Controls.Add(textBoxLargura);
            groupBox1.Controls.Add(textBoxaltura);
            groupBox1.Controls.Add(radioButtonPerimetro);
            groupBox1.Controls.Add(radioButtonÁrea);
            groupBox1.Controls.Add(buttonCalcular);
            groupBox1.Location = new Point(24, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 168);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(97, 131);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(77, 23);
            textBoxResultado.TabIndex = 24;
            // 
            // textBoxCompri
            // 
            textBoxCompri.Location = new Point(97, 52);
            textBoxCompri.Name = "textBoxCompri";
            textBoxCompri.Size = new Size(77, 23);
            textBoxCompri.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 133);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 22;
            label2.Text = "Resultado:";
            // 
            // labelcompri
            // 
            labelcompri.AutoSize = true;
            labelcompri.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcompri.Location = new Point(0, 52);
            labelcompri.Name = "labelcompri";
            labelcompri.Size = new Size(97, 19);
            labelcompri.TabIndex = 21;
            labelcompri.Text = "Comprimento:";
            // 
            // labellargura
            // 
            labellargura.AutoSize = true;
            labellargura.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labellargura.Location = new Point(0, 91);
            labellargura.Name = "labellargura";
            labellargura.Size = new Size(63, 19);
            labellargura.TabIndex = 20;
            labellargura.Text = "Largura:";
            // 
            // radioButtonVol
            // 
            radioButtonVol.AutoSize = true;
            radioButtonVol.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonVol.Location = new Point(196, 131);
            radioButtonVol.Name = "radioButtonVol";
            radioButtonVol.Size = new Size(74, 23);
            radioButtonVol.TabIndex = 19;
            radioButtonVol.TabStop = true;
            radioButtonVol.Text = "Volume";
            radioButtonVol.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerimetro
            // 
            radioButtonPerimetro.AutoSize = true;
            radioButtonPerimetro.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonPerimetro.Location = new Point(196, 73);
            radioButtonPerimetro.Name = "radioButtonPerimetro";
            radioButtonPerimetro.Size = new Size(88, 23);
            radioButtonPerimetro.TabIndex = 18;
            radioButtonPerimetro.TabStop = true;
            radioButtonPerimetro.Text = "Perímetro";
            radioButtonPerimetro.UseVisualStyleBackColor = true;
            // 
            // radioButtonÁrea
            // 
            radioButtonÁrea.AutoSize = true;
            radioButtonÁrea.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonÁrea.Location = new Point(196, 22);
            radioButtonÁrea.Name = "radioButtonÁrea";
            radioButtonÁrea.Size = new Size(56, 23);
            radioButtonÁrea.TabIndex = 17;
            radioButtonÁrea.TabStop = true;
            radioButtonÁrea.Text = "Área";
            radioButtonÁrea.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonCalcularQua);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(textBoxresultado2);
            groupBox2.Controls.Add(textBoxlado);
            groupBox2.Controls.Add(labelresultado2);
            groupBox2.Controls.Add(labellado);
            groupBox2.Location = new Point(465, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 168);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Visible = false;
            // 
            // buttonCalcularQua
            // 
            buttonCalcularQua.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCalcularQua.Location = new Point(299, 73);
            buttonCalcularQua.Name = "buttonCalcularQua";
            buttonCalcularQua.Size = new Size(75, 23);
            buttonCalcularQua.TabIndex = 23;
            buttonCalcularQua.Text = " Calcular";
            buttonCalcularQua.UseVisualStyleBackColor = true;
            buttonCalcularQua.Click += buttonCalcularQua_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(184, 125);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(74, 23);
            radioButton4.TabIndex = 22;
            radioButton4.TabStop = true;
            radioButton4.Text = "Volume";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(184, 18);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(56, 23);
            radioButton3.TabIndex = 21;
            radioButton3.TabStop = true;
            radioButton3.Text = "Área";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(184, 73);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(88, 23);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Perímetro";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxresultado2
            // 
            textBoxresultado2.Location = new Point(84, 53);
            textBoxresultado2.Name = "textBoxresultado2";
            textBoxresultado2.ReadOnly = true;
            textBoxresultado2.Size = new Size(79, 23);
            textBoxresultado2.TabIndex = 19;
            // 
            // textBoxlado
            // 
            textBoxlado.Location = new Point(84, 15);
            textBoxlado.Name = "textBoxlado";
            textBoxlado.Size = new Size(79, 23);
            textBoxlado.TabIndex = 18;
            // 
            // labelresultado2
            // 
            labelresultado2.AutoSize = true;
            labelresultado2.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelresultado2.Location = new Point(6, 56);
            labelresultado2.Name = "labelresultado2";
            labelresultado2.Size = new Size(73, 19);
            labelresultado2.TabIndex = 18;
            labelresultado2.Text = "Resultado:";
            // 
            // labellado
            // 
            labellado.AutoSize = true;
            labellado.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labellado.Location = new Point(6, 18);
            labellado.Name = "labellado";
            labellado.Size = new Size(43, 19);
            labellado.TabIndex = 18;
            labellado.Text = "Lado:";
            // 
            // buttonnovoform
            // 
            buttonnovoform.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonnovoform.Location = new Point(371, 469);
            buttonnovoform.Name = "buttonnovoform";
            buttonnovoform.Size = new Size(143, 23);
            buttonnovoform.TabIndex = 18;
            buttonnovoform.Text = "Novo Form";
            buttonnovoform.UseVisualStyleBackColor = true;
            buttonnovoform.Click += buttonnovoform_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBoxResultadoCirculo);
            groupBox3.Controls.Add(radioButtonvol3);
            groupBox3.Controls.Add(radioButtonperi3);
            groupBox3.Controls.Add(radioButtondiametro);
            groupBox3.Controls.Add(radioButtonarea3);
            groupBox3.Controls.Add(labelRaio);
            groupBox3.Controls.Add(textBoxRaio);
            groupBox3.Location = new Point(235, 283);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(393, 180);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Visible = false;
            // 
            // button2
            // 
            button2.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(301, 71);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 57);
            label7.Name = "label7";
            label7.Size = new Size(73, 19);
            label7.TabIndex = 7;
            label7.Text = "Resultado:";
            // 
            // textBoxResultadoCirculo
            // 
            textBoxResultadoCirculo.Location = new Point(97, 56);
            textBoxResultadoCirculo.Name = "textBoxResultadoCirculo";
            textBoxResultadoCirculo.ReadOnly = true;
            textBoxResultadoCirculo.Size = new Size(77, 23);
            textBoxResultadoCirculo.TabIndex = 6;
            // 
            // radioButtonvol3
            // 
            radioButtonvol3.AutoSize = true;
            radioButtonvol3.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonvol3.Location = new Point(196, 106);
            radioButtonvol3.Name = "radioButtonvol3";
            radioButtonvol3.Size = new Size(74, 23);
            radioButtonvol3.TabIndex = 5;
            radioButtonvol3.TabStop = true;
            radioButtonvol3.Text = "Volume";
            radioButtonvol3.UseVisualStyleBackColor = true;
            // 
            // radioButtonperi3
            // 
            radioButtonperi3.AutoSize = true;
            radioButtonperi3.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonperi3.Location = new Point(196, 81);
            radioButtonperi3.Name = "radioButtonperi3";
            radioButtonperi3.Size = new Size(88, 23);
            radioButtonperi3.TabIndex = 4;
            radioButtonperi3.TabStop = true;
            radioButtonperi3.Text = "Perímetro";
            radioButtonperi3.UseVisualStyleBackColor = true;
            // 
            // radioButtondiametro
            // 
            radioButtondiametro.AutoSize = true;
            radioButtondiametro.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtondiametro.Location = new Point(196, 56);
            radioButtondiametro.Name = "radioButtondiametro";
            radioButtondiametro.Size = new Size(85, 23);
            radioButtondiametro.TabIndex = 3;
            radioButtondiametro.TabStop = true;
            radioButtondiametro.Text = "Diâmetro";
            radioButtondiametro.UseVisualStyleBackColor = true;
            // 
            // radioButtonarea3
            // 
            radioButtonarea3.AutoSize = true;
            radioButtonarea3.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonarea3.Location = new Point(196, 31);
            radioButtonarea3.Name = "radioButtonarea3";
            radioButtonarea3.Size = new Size(56, 23);
            radioButtonarea3.TabIndex = 2;
            radioButtonarea3.TabStop = true;
            radioButtonarea3.Text = "Área";
            radioButtonarea3.UseVisualStyleBackColor = true;
            // 
            // labelRaio
            // 
            labelRaio.AutoSize = true;
            labelRaio.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRaio.Location = new Point(12, 27);
            labelRaio.Name = "labelRaio";
            labelRaio.Size = new Size(40, 19);
            labelRaio.TabIndex = 1;
            labelRaio.Text = "Raio:";
            // 
            // textBoxRaio
            // 
            textBoxRaio.Location = new Point(97, 27);
            textBoxRaio.Name = "textBoxRaio";
            textBoxRaio.Size = new Size(77, 23);
            textBoxRaio.TabIndex = 0;
            // 
            // radioButtonCompri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 519);
            Controls.Add(groupBox3);
            Controls.Add(buttonnovoform);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(labelErro);
            Controls.Add(comboBoxFormas);
            Controls.Add(label1);
            Controls.Add(labelTitulo1);
            Name = "radioButtonCompri";
            Text = "Área";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitulo1;
        private Label label1;
        private Button buttonCalcular;
        private TextBox textBoxLargura;
        private TextBox textBoxaltura;
        private ComboBox comboBoxFormas;
        private Label labelAltura;
        private Label labelErro;
        private GroupBox groupBox1;
        private RadioButton radioButtonÁrea;
        private RadioButton radioButtonVol;
        private RadioButton radioButtonPerimetro;
        private Label labelcompri;
        private Label labellargura;
        private Label label2;
        private TextBox textBoxResultado;
        private TextBox textBoxCompri;
        private GroupBox groupBox2;
        private TextBox textBoxresultado2;
        private TextBox textBoxlado;
        private Label labelresultado2;
        private Label labellado;
        private Button buttonCalcularQua;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Button buttonnovoform;
        private GroupBox groupBox3;
        private RadioButton radioButtonvol3;
        private RadioButton radioButtonperi3;
        private RadioButton radioButtondiametro;
        private RadioButton radioButtonarea3;
        private Label labelRaio;
        private TextBox textBoxRaio;
        private Button button2;
        private Label label7;
        private TextBox textBoxResultadoCirculo;
    }
}