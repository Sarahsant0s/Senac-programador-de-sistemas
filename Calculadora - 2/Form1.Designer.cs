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
            labelTitulo = new Label();
            labelResultado = new Label();
            label1 = new Label();
            buttonresultado = new Button();
            comboBox1 = new ComboBox();
            textboxValor = new TextBox();
            labelsinal = new Label();
            buttonnovoform = new Button();
            SuspendLayout();
            // 
            // textboxValor1
            // 
            textboxValor1.Location = new Point(90, 89);
            textboxValor1.Name = "textboxValor1";
            textboxValor1.Size = new Size(59, 23);
            textboxValor1.TabIndex = 0;
            // 
            // textboxValor2
            // 
            textboxValor2.Location = new Point(194, 89);
            textboxValor2.Name = "textboxValor2";
            textboxValor2.Size = new Size(57, 23);
            textboxValor2.TabIndex = 1;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(109, 28);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(117, 19);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "Calculadora";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(90, 60);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(214, 16);
            labelResultado.TabIndex = 7;
            labelResultado.Text = "Insira os valores para executar o cáculo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 92);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 8;
            label1.Text = "=";
            // 
            // buttonresultado
            // 
            buttonresultado.Location = new Point(137, 147);
            buttonresultado.Name = "buttonresultado";
            buttonresultado.Size = new Size(78, 23);
            buttonresultado.TabIndex = 16;
            buttonresultado.Text = "Calcular";
            buttonresultado.UseVisualStyleBackColor = true;
            buttonresultado.Click += buttonresultado_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Somar", "Subtrair", "Dividir", "Multiplicar" });
            comboBox1.Location = new Point(99, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 23);
            comboBox1.TabIndex = 17;
            comboBox1.Text = "Selecione a operação";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textboxValor
            // 
            textboxValor.BackColor = SystemColors.ControlLight;
            textboxValor.Enabled = false;
            textboxValor.Location = new Point(278, 89);
            textboxValor.Name = "textboxValor";
            textboxValor.ReadOnly = true;
            textboxValor.Size = new Size(56, 23);
            textboxValor.TabIndex = 18;
            // 
            // labelsinal
            // 
            labelsinal.AutoSize = true;
            labelsinal.Location = new Point(166, 92);
            labelsinal.Name = "labelsinal";
            labelsinal.Size = new Size(0, 15);
            labelsinal.TabIndex = 19;
            // 
            // buttonnovoform
            // 
            buttonnovoform.Location = new Point(137, 282);
            buttonnovoform.Name = "buttonnovoform";
            buttonnovoform.Size = new Size(89, 30);
            buttonnovoform.TabIndex = 20;
            buttonnovoform.Text = "Novo Form";
            buttonnovoform.UseVisualStyleBackColor = true;
            buttonnovoform.Click += buttonnovoform_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonnovoform);
            Controls.Add(labelsinal);
            Controls.Add(textboxValor);
            Controls.Add(comboBox1);
            Controls.Add(buttonresultado);
            Controls.Add(label1);
            Controls.Add(labelResultado);
            Controls.Add(labelTitulo);
            Controls.Add(textboxValor2);
            Controls.Add(textboxValor1);
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxValor1;
        private TextBox textboxValor2;
        private Label labelTitulo;
        private Label labelResultado;
        private Label label1;
        private Button buttonresultado;
        private ComboBox comboBox1;
        private TextBox textboxValor;
        private Label labelsinal;
        private Button buttonnovoform;
    }
}
