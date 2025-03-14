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
            labelBase = new Label();
            labelAltura = new Label();
            labelErro = new Label();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButtonPerimetro = new RadioButton();
            radioButtonVol = new RadioButton();
            labellargura = new Label();
            labelcompri = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBoxResultado = new TextBox();
            groupBox2 = new GroupBox();
            labellado = new Label();
            labelresultado2 = new Label();
            textBoxlado = new TextBox();
            textBoxresultado2 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            buttonnovoform = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            textBoxLargura.Visible = false;
            // 
            // textBoxaltura
            // 
            textBoxaltura.Location = new Point(97, 15);
            textBoxaltura.Name = "textBoxaltura";
            textBoxaltura.Size = new Size(77, 23);
            textBoxaltura.TabIndex = 10;
            textBoxaltura.Visible = false;
            // 
            // comboBoxFormas
            // 
            comboBoxFormas.FormattingEnabled = true;
            comboBoxFormas.Items.AddRange(new object[] { "Quadrado", "Retângulo" });
            comboBoxFormas.Location = new Point(9, 80);
            comboBoxFormas.Name = "comboBoxFormas";
            comboBoxFormas.Size = new Size(135, 23);
            comboBoxFormas.TabIndex = 11;
            comboBoxFormas.SelectedIndexChanged += comboBoxFormas_SelectedIndexChanged;
            // 
            // labelBase
            // 
            labelBase.AutoSize = true;
            labelBase.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBase.ForeColor = SystemColors.ActiveCaptionText;
            labelBase.Location = new Point(658, 236);
            labelBase.Name = "labelBase";
            labelBase.Size = new Size(37, 19);
            labelBase.TabIndex = 13;
            labelBase.Text = "Base";
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
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labelcompri);
            groupBox1.Controls.Add(labellargura);
            groupBox1.Controls.Add(labelAltura);
            groupBox1.Controls.Add(radioButtonVol);
            groupBox1.Controls.Add(textBoxLargura);
            groupBox1.Controls.Add(textBoxaltura);
            groupBox1.Controls.Add(radioButtonPerimetro);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(buttonCalcular);
            groupBox1.Location = new Point(9, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 168);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(196, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(56, 23);
            radioButton1.TabIndex = 17;
            radioButton1.TabStop = true;
            radioButton1.Text = "Área";
            radioButton1.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(97, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(77, 23);
            textBox1.TabIndex = 23;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(97, 131);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(77, 23);
            textBoxResultado.TabIndex = 24;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(textBoxresultado2);
            groupBox2.Controls.Add(textBoxlado);
            groupBox2.Controls.Add(labelresultado2);
            groupBox2.Controls.Add(labellado);
            groupBox2.Location = new Point(474, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 168);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
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
            // textBoxlado
            // 
            textBoxlado.Location = new Point(84, 15);
            textBoxlado.Name = "textBoxlado";
            textBoxlado.Size = new Size(79, 23);
            textBoxlado.TabIndex = 18;
            // 
            // textBoxresultado2
            // 
            textBoxresultado2.Location = new Point(84, 53);
            textBoxresultado2.Name = "textBoxresultado2";
            textBoxresultado2.Size = new Size(79, 23);
            textBoxresultado2.TabIndex = 19;
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
            // button1
            // 
            button1.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(299, 73);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonnovoform
            // 
            buttonnovoform.Location = new Point(408, 354);
            buttonnovoform.Name = "buttonnovoform";
            buttonnovoform.Size = new Size(75, 23);
            buttonnovoform.TabIndex = 18;
            buttonnovoform.Text = "Novo Form";
            buttonnovoform.UseVisualStyleBackColor = true;
            buttonnovoform.Click += buttonnovoform_Click;
            // 
            // radioButtonCompri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 450);
            Controls.Add(buttonnovoform);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(labelErro);
            Controls.Add(labelBase);
            Controls.Add(comboBoxFormas);
            Controls.Add(label1);
            Controls.Add(labelTitulo1);
            Name = "radioButtonCompri";
            Text = "Área";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Label labelBase;
        private Label labelAltura;
        private Label labelErro;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButtonVol;
        private RadioButton radioButtonPerimetro;
        private Label labelcompri;
        private Label labellargura;
        private Label label2;
        private TextBox textBoxResultado;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBoxresultado2;
        private TextBox textBoxlado;
        private Label labelresultado2;
        private Label labellado;
        private Button button1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Button buttonnovoform;
    }
}