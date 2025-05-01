namespace Projeto_Integrador
{
    partial class Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            pictureBox1 = new PictureBox();
            buttonBuscar = new Button();
            textBoxBuscarNomeCliente = new TextBox();
            numericUpDownQuantidade = new NumericUpDown();
            labelCliente = new Label();
            labelQuant = new Label();
            labelServico = new Label();
            labelProduto = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            buttonConcluirPedido = new Button();
            dataGridView1 = new DataGridView();
            comboBoxOpcaoPagamento = new ComboBox();
            textBoxValorFinal = new TextBox();
            checkBoxPagamento = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(459, 263);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(436, 284);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(820, 38);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 1;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarNomeCliente
            // 
            textBoxBuscarNomeCliente.Location = new Point(459, 38);
            textBoxBuscarNomeCliente.Name = "textBoxBuscarNomeCliente";
            textBoxBuscarNomeCliente.Size = new Size(355, 23);
            textBoxBuscarNomeCliente.TabIndex = 2;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(183, 137);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(120, 23);
            numericUpDownQuantidade.TabIndex = 5;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(457, 20);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(47, 15);
            labelCliente.TabIndex = 6;
            labelCliente.Text = "Cliente:";
            // 
            // labelQuant
            // 
            labelQuant.AutoSize = true;
            labelQuant.Location = new Point(183, 119);
            labelQuant.Name = "labelQuant";
            labelQuant.Size = new Size(72, 15);
            labelQuant.TabIndex = 7;
            labelQuant.Text = "Quantidade:";
            // 
            // labelServico
            // 
            labelServico.AutoSize = true;
            labelServico.Location = new Point(12, 64);
            labelServico.Name = "labelServico";
            labelServico.Size = new Size(48, 15);
            labelServico.TabIndex = 8;
            labelServico.Text = "Serviço:";
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Location = new Point(183, 64);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(53, 15);
            labelProduto.TabIndex = 9;
            labelProduto.Text = "Produto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 263);
            label5.Name = "label5";
            label5.Size = new Size(10, 15);
            label5.TabIndex = 10;
            label5.Text = ".";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Amarrador", "Água Oxigenada", "Condicionador", "Escova", "Hidratante Labial", "Leave-in", "Luva", "Máscara facial ", "Máscara de tratamento", "Maquiagens", "Modelador de cachos", "Óleos", "Pente ", "Pó descolorante", "Protetor solar capilar", "Protetor térmico", "Reparador de pontas", "Shampoo", "Spray fixador" });
            comboBox1.Location = new Point(183, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Alisamento", "Cortes", "Coloração", "Escova", "Hidratação", "Luzes", "Mechas", "Nutrição", "Penteados", "Progressiva", "Reconstrução", "Sobrancelha" });
            comboBox2.Location = new Point(12, 82);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 12;
            // 
            // buttonConcluirPedido
            // 
            buttonConcluirPedido.Location = new Point(89, 286);
            buttonConcluirPedido.Name = "buttonConcluirPedido";
            buttonConcluirPedido.Size = new Size(135, 23);
            buttonConcluirPedido.TabIndex = 13;
            buttonConcluirPedido.Text = "Concluir Pedido";
            buttonConcluirPedido.UseVisualStyleBackColor = true;
            buttonConcluirPedido.Click += buttonConcluirPedido_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(459, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(436, 231);
            dataGridView1.TabIndex = 14;
            // 
            // comboBoxOpcaoPagamento
            // 
            comboBoxOpcaoPagamento.FormattingEnabled = true;
            comboBoxOpcaoPagamento.Items.AddRange(new object[] { "Boletos", "Cartão de Crédito & Débito", "Carteira Digital", "Dinheiro", "Links de Pagamento", "Pix", "Transferências Bancárias" });
            comboBoxOpcaoPagamento.Location = new Point(12, 185);
            comboBoxOpcaoPagamento.Name = "comboBoxOpcaoPagamento";
            comboBoxOpcaoPagamento.Size = new Size(121, 23);
            comboBoxOpcaoPagamento.TabIndex = 15;
            // 
            // textBoxValorFinal
            // 
            textBoxValorFinal.Enabled = false;
            textBoxValorFinal.Location = new Point(183, 185);
            textBoxValorFinal.Name = "textBoxValorFinal";
            textBoxValorFinal.ReadOnly = true;
            textBoxValorFinal.Size = new Size(120, 23);
            textBoxValorFinal.TabIndex = 16;
            // 
            // checkBoxPagamento
            // 
            checkBoxPagamento.AutoSize = true;
            checkBoxPagamento.Location = new Point(12, 214);
            checkBoxPagamento.Name = "checkBoxPagamento";
            checkBoxPagamento.Size = new Size(171, 19);
            checkBoxPagamento.TabIndex = 17;
            checkBoxPagamento.Text = "Pagamento Posteriormente";
            checkBoxPagamento.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 20);
            label1.Name = "label1";
            label1.Size = new Size(182, 27);
            label1.TabIndex = 18;
            label1.Text = "Adicionar Pedido";
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(922, 508);
            Controls.Add(label1);
            Controls.Add(checkBoxPagamento);
            Controls.Add(textBoxValorFinal);
            Controls.Add(comboBoxOpcaoPagamento);
            Controls.Add(dataGridView1);
            Controls.Add(buttonConcluirPedido);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(labelProduto);
            Controls.Add(labelServico);
            Controls.Add(labelQuant);
            Controls.Add(labelCliente);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(textBoxBuscarNomeCliente);
            Controls.Add(buttonBuscar);
            Controls.Add(pictureBox1);
            Name = "Vendas";
            Text = "Pedido";
            Load += Vendas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonBuscar;
        private TextBox textBoxBuscarNomeCliente;
        private NumericUpDown numericUpDownQuantidade;
        private Label labelCliente;
        private Label labelQuant;
        private Label labelServico;
        private Label labelProduto;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button buttonConcluirPedido;
        private DataGridView dataGridView1;
        private ComboBox comboBoxOpcaoPagamento;
        private TextBox textBoxValorFinal;
        private CheckBox checkBoxPagamento;
        private Label label1;
    }
}