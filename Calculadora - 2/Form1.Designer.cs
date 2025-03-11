namespace Calculadora___2
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
            textboxValor1 = new TextBox();
            textboxValor2 = new TextBox();
            buttonCalcular = new Button();
            labelTitulo = new Label();
            buttonmenos = new Button();
            buttonmult = new Button();
            buttondivi = new Button();
            labelResultado = new Label();
            label1 = new Label();
            labelValor = new Label();
            SuspendLayout();
            // 
            // textboxValor1
            // 
            textboxValor1.Location = new Point(41, 73);
            textboxValor1.Name = "textboxValor1";
            textboxValor1.Size = new Size(100, 23);
            textboxValor1.TabIndex = 0;
            // 
            // textboxValor2
            // 
            textboxValor2.Location = new Point(211, 73);
            textboxValor2.Name = "textboxValor2";
            textboxValor2.Size = new Size(100, 23);
            textboxValor2.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(179, 121);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(28, 27);
            buttonCalcular.TabIndex = 2;
            buttonCalcular.Text = "+";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(112, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(117, 19);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "Calculadora";
            // 
            // buttonmenos
            // 
            buttonmenos.Location = new Point(143, 154);
            buttonmenos.Name = "buttonmenos";
            buttonmenos.Size = new Size(30, 28);
            buttonmenos.TabIndex = 4;
            buttonmenos.Text = "-";
            buttonmenos.UseVisualStyleBackColor = true;
            buttonmenos.Click += buttonmenos_Click;
            // 
            // buttonmult
            // 
            buttonmult.Location = new Point(179, 154);
            buttonmult.Name = "buttonmult";
            buttonmult.Size = new Size(28, 28);
            buttonmult.TabIndex = 5;
            buttonmult.Text = "*";
            buttonmult.UseVisualStyleBackColor = true;
            buttonmult.Click += buttonmult_Click;
            // 
            // buttondivi
            // 
            buttondivi.Location = new Point(143, 121);
            buttondivi.Name = "buttondivi";
            buttondivi.Size = new Size(30, 27);
            buttondivi.TabIndex = 6;
            buttondivi.Text = "/";
            buttondivi.UseVisualStyleBackColor = true;
            buttondivi.Click += buttondivi_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(41, 38);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(274, 12);
            labelResultado.TabIndex = 7;
            labelResultado.Text = "Insira os valores para executar o cáculo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 77);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 8;
            label1.Text = "=";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(347, 77);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(0, 15);
            labelValor.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelValor);
            Controls.Add(label1);
            Controls.Add(labelResultado);
            Controls.Add(buttondivi);
            Controls.Add(buttonmult);
            Controls.Add(buttonmenos);
            Controls.Add(labelTitulo);
            Controls.Add(buttonCalcular);
            Controls.Add(textboxValor2);
            Controls.Add(textboxValor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxValor1;
        private TextBox textboxValor2;
        private Button buttonCalcular;
        private Label labelTitulo;
        private Button buttonmenos;
        private Button buttonmult;
        private Button buttondivi;
        private Label labelResultado;
        private Label label1;
        private Label labelValor;
    }
}
