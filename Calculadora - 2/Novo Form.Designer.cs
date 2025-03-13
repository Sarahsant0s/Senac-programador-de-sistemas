namespace Calculadora___2
{
    partial class Novo_Form
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
            labelTitulo2 = new Label();
            buttonCalcular = new Button();
            textBoxbase = new TextBox();
            textBoxaltura = new TextBox();
            comboBoxFormas = new ComboBox();
            comboBoxCalculo = new ComboBox();
            labelBase = new Label();
            labelAltura = new Label();
            labelErro = new Label();
            SuspendLayout();
            // 
            // labelTitulo1
            // 
            labelTitulo1.AutoSize = true;
            labelTitulo1.BackColor = SystemColors.ActiveCaption;
            labelTitulo1.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo1.Location = new Point(103, 68);
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
            label1.Location = new Point(228, 19);
            label1.Name = "label1";
            label1.Size = new Size(190, 22);
            label1.TabIndex = 3;
            label1.Text = "CALCULE A FORMA";
            // 
            // labelTitulo2
            // 
            labelTitulo2.AutoSize = true;
            labelTitulo2.BackColor = SystemColors.ActiveCaption;
            labelTitulo2.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo2.Location = new Point(362, 68);
            labelTitulo2.Name = "labelTitulo2";
            labelTitulo2.Size = new Size(270, 18);
            labelTitulo2.TabIndex = 4;
            labelTitulo2.Text = "Selecione o Perímetro, Área ou Volume:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(292, 142);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 8;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            // 
            // textBoxbase
            // 
            textBoxbase.Location = new Point(402, 203);
            textBoxbase.Name = "textBoxbase";
            textBoxbase.Size = new Size(52, 23);
            textBoxbase.TabIndex = 9;
            textBoxbase.Visible = false;
            // 
            // textBoxaltura
            // 
            textBoxaltura.Location = new Point(500, 203);
            textBoxaltura.Name = "textBoxaltura";
            textBoxaltura.Size = new Size(56, 23);
            textBoxaltura.TabIndex = 10;
            textBoxaltura.Visible = false;
            // 
            // comboBoxFormas
            // 
            comboBoxFormas.FormattingEnabled = true;
            comboBoxFormas.Items.AddRange(new object[] { "Quadrado", "Retângulo" });
            comboBoxFormas.Location = new Point(132, 99);
            comboBoxFormas.Name = "comboBoxFormas";
            comboBoxFormas.Size = new Size(135, 23);
            comboBoxFormas.TabIndex = 11;
            comboBoxFormas.Text = "Formas geométricas";
            comboBoxFormas.SelectedIndexChanged += comboBoxFormas_SelectedIndexChanged;
            // 
            // comboBoxCalculo
            // 
            comboBoxCalculo.FormattingEnabled = true;
            comboBoxCalculo.Items.AddRange(new object[] { "Área", "Perímetro", "Volume" });
            comboBoxCalculo.Location = new Point(422, 99);
            comboBoxCalculo.Name = "comboBoxCalculo";
            comboBoxCalculo.Size = new Size(121, 23);
            comboBoxCalculo.TabIndex = 12;
            comboBoxCalculo.Text = "Cálculos";
            comboBoxCalculo.SelectedIndexChanged += comboBoxCalculo_SelectedIndexChanged;
            // 
            // labelBase
            // 
            labelBase.AutoSize = true;
            labelBase.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBase.ForeColor = SystemColors.ActiveCaptionText;
            labelBase.Location = new Point(402, 169);
            labelBase.Name = "labelBase";
            labelBase.Size = new Size(37, 19);
            labelBase.TabIndex = 13;
            labelBase.Text = "Base";
            // 
            // labelAltura
            // 
            labelAltura.AutoSize = true;
            labelAltura.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAltura.Location = new Point(500, 169);
            labelAltura.Name = "labelAltura";
            labelAltura.Size = new Size(49, 19);
            labelAltura.TabIndex = 14;
            labelAltura.Text = "Altura";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(459, 262);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 15;
            // 
            // Novo_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelErro);
            Controls.Add(labelAltura);
            Controls.Add(labelBase);
            Controls.Add(comboBoxCalculo);
            Controls.Add(comboBoxFormas);
            Controls.Add(textBoxaltura);
            Controls.Add(textBoxbase);
            Controls.Add(buttonCalcular);
            Controls.Add(labelTitulo2);
            Controls.Add(label1);
            Controls.Add(labelTitulo1);
            Name = "Novo_Form";
            Text = "Novo_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitulo1;
        private Label label1;
        private Label labelTitulo2;
        private Button buttonCalcular;
        private TextBox textBoxbase;
        private TextBox textBoxaltura;
        private ComboBox comboBoxFormas;
        private ComboBox comboBoxCalculo;
        private Label labelBase;
        private Label labelAltura;
        private Label labelErro;
    }
}