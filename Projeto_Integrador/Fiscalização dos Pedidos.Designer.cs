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
            dataGridView1 = new DataGridView();
            labelTitulo = new Label();
            textBox1 = new TextBox();
            labelIdPedido = new Label();
            labelCPFCliente = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            labelErro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(343, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(494, 324);
            dataGridView1.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Bell MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(51, 27);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(230, 27);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Pedidos em Pendência";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // labelIdPedido
            // 
            labelIdPedido.AutoSize = true;
            labelIdPedido.Location = new Point(176, 70);
            labelIdPedido.Name = "labelIdPedido";
            labelIdPedido.Size = new Size(77, 15);
            labelIdPedido.TabIndex = 3;
            labelIdPedido.Text = "Id do Pedido:";
            // 
            // labelCPFCliente
            // 
            labelCPFCliente.AutoSize = true;
            labelCPFCliente.Location = new Point(24, 70);
            labelCPFCliente.Name = "labelCPFCliente";
            labelCPFCliente.Size = new Size(88, 15);
            labelCPFCliente.TabIndex = 4;
            labelCPFCliente.Text = "CPF do Cliente:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(24, 88);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(97, 151);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 6;
            button1.Text = "Procurar Pedido";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-21, 310);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(24, 232);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(10, 15);
            labelErro.TabIndex = 8;
            labelErro.Text = ".";
            // 
            // Fiscalização_dos_Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(892, 520);
            Controls.Add(labelErro);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(labelCPFCliente);
            Controls.Add(labelIdPedido);
            Controls.Add(textBox1);
            Controls.Add(labelTitulo);
            Controls.Add(dataGridView1);
            Name = "Fiscalização_dos_Pedidos";
            Text = "Fiscalização_dos_Pedidos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelTitulo;
        private TextBox textBox1;
        private Label labelIdPedido;
        private Label labelCPFCliente;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label labelErro;
    }
}