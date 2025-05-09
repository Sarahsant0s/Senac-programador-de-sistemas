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
            labelErro = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            buttonConcluirPedido = new Button();
            dataGridViewBuscarClientes = new DataGridView();
            comboBoxOpcaoPagamento = new ComboBox();
            textBoxValorFinal = new TextBox();
            checkBoxPagamento = new CheckBox();
            labelTitulo = new Label();
            labelFormaDePag = new Label();
            labelValorTotal = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuscarClientes).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(252, 289);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(419, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = SystemColors.ActiveBorder;
            buttonBuscar.Location = new Point(321, 39);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 1;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // textBoxBuscarNomeCliente
            // 
            textBoxBuscarNomeCliente.Location = new Point(6, 40);
            textBoxBuscarNomeCliente.Name = "textBoxBuscarNomeCliente";
            textBoxBuscarNomeCliente.Size = new Size(309, 23);
            textBoxBuscarNomeCliente.TabIndex = 2;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(321, 99);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(120, 23);
            numericUpDownQuantidade.TabIndex = 5;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(6, 19);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(173, 15);
            labelCliente.TabIndex = 6;
            labelCliente.Text = "Nome e Sobrenome do Cliente:";
            // 
            // labelQuant
            // 
            labelQuant.AutoSize = true;
            labelQuant.Location = new Point(321, 80);
            labelQuant.Name = "labelQuant";
            labelQuant.Size = new Size(69, 15);
            labelQuant.TabIndex = 7;
            labelQuant.Text = "Quantidade";
            // 
            // labelServico
            // 
            labelServico.AutoSize = true;
            labelServico.Location = new Point(6, 80);
            labelServico.Name = "labelServico";
            labelServico.Size = new Size(45, 15);
            labelServico.TabIndex = 8;
            labelServico.Text = "Serviço";
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Location = new Point(194, 80);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(50, 15);
            labelProduto.TabIndex = 9;
            labelProduto.Text = "Produto";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(6, 246);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(10, 15);
            labelErro.TabIndex = 10;
            labelErro.Text = ".";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Amarrador", "Água Oxigenada", "Borrifador", "Condicionador", "Creme para cabelos lisos", "Creme para cabelos cacheados/crespos", "Escova", "Esponja Twist", "Gel", "Gelatina", "Hidratante Labial", "Leave-in", "Luva", "Máscara facial ", "Máscara de tratamento", "Maquiagens", "Modelador de cachos", "Óleos", "Pente ", "Pente Garfo", "Pó descolorante", "Pomada", "Protetor solar capilar", "Protetor térmico", "Reparador de pontas", "Shampoo", "Spray fixador" });
            comboBox1.Location = new Point(194, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Alisamento", "Barba ", "Corte Feminino", "Corte Masculino", "Coloração", "Descoloração", "Escova", "Hidratação", "Lavagem", "Luzes", "Mechas", "Nutrição", "Penteados", "Progressiva", "Reconstrução", "Sobrancelha" });
            comboBox2.Location = new Point(6, 98);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(124, 23);
            comboBox2.TabIndex = 12;
            // 
            // buttonConcluirPedido
            // 
            buttonConcluirPedido.BackColor = SystemColors.ActiveBorder;
            buttonConcluirPedido.Location = new Point(89, 244);
            buttonConcluirPedido.Name = "buttonConcluirPedido";
            buttonConcluirPedido.Size = new Size(153, 23);
            buttonConcluirPedido.TabIndex = 13;
            buttonConcluirPedido.Text = "Concluir Pedido";
            buttonConcluirPedido.UseVisualStyleBackColor = false;
            buttonConcluirPedido.Click += buttonConcluirPedido_Click;
            // 
            // dataGridViewBuscarClientes
            // 
            dataGridViewBuscarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuscarClientes.Location = new Point(463, 67);
            dataGridViewBuscarClientes.Name = "dataGridViewBuscarClientes";
            dataGridViewBuscarClientes.Size = new Size(447, 249);
            dataGridViewBuscarClientes.TabIndex = 14;
            // 
            // comboBoxOpcaoPagamento
            // 
            comboBoxOpcaoPagamento.FormattingEnabled = true;
            comboBoxOpcaoPagamento.Items.AddRange(new object[] { "Boletos", "Cartão de Crédito & Débito", "Carteira Digital", "Dinheiro", "Links de Pagamento", "Pix", "Transferências Bancárias" });
            comboBoxOpcaoPagamento.Location = new Point(5, 165);
            comboBoxOpcaoPagamento.Name = "comboBoxOpcaoPagamento";
            comboBoxOpcaoPagamento.Size = new Size(124, 23);
            comboBoxOpcaoPagamento.TabIndex = 15;
            // 
            // textBoxValorFinal
            // 
            textBoxValorFinal.BackColor = SystemColors.ActiveBorder;
            textBoxValorFinal.Enabled = false;
            textBoxValorFinal.Location = new Point(194, 163);
            textBoxValorFinal.Name = "textBoxValorFinal";
            textBoxValorFinal.ReadOnly = true;
            textBoxValorFinal.Size = new Size(120, 23);
            textBoxValorFinal.TabIndex = 16;
            // 
            // checkBoxPagamento
            // 
            checkBoxPagamento.AutoSize = true;
            checkBoxPagamento.Location = new Point(89, 204);
            checkBoxPagamento.Name = "checkBoxPagamento";
            checkBoxPagamento.Size = new Size(158, 19);
            checkBoxPagamento.TabIndex = 17;
            checkBoxPagamento.Text = "Pagamento Subsequente";
            checkBoxPagamento.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Elephant", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(345, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(223, 31);
            labelTitulo.TabIndex = 18;
            labelTitulo.Text = "Adicionar Pedido";
            // 
            // labelFormaDePag
            // 
            labelFormaDePag.AutoSize = true;
            labelFormaDePag.Location = new Point(5, 145);
            labelFormaDePag.Name = "labelFormaDePag";
            labelFormaDePag.Size = new Size(124, 15);
            labelFormaDePag.TabIndex = 19;
            labelFormaDePag.Text = "Forma de Pagamento:";
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.Location = new Point(194, 145);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(64, 15);
            labelValorTotal.TabIndex = 20;
            labelValorTotal.Text = "Valor Total:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(673, 484);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(labelCliente);
            groupBox1.Controls.Add(buttonBuscar);
            groupBox1.Controls.Add(labelValorTotal);
            groupBox1.Controls.Add(numericUpDownQuantidade);
            groupBox1.Controls.Add(labelFormaDePag);
            groupBox1.Controls.Add(labelQuant);
            groupBox1.Controls.Add(labelServico);
            groupBox1.Controls.Add(checkBoxPagamento);
            groupBox1.Controls.Add(labelProduto);
            groupBox1.Controls.Add(textBoxValorFinal);
            groupBox1.Controls.Add(labelErro);
            groupBox1.Controls.Add(comboBoxOpcaoPagamento);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(buttonConcluirPedido);
            groupBox1.Controls.Add(textBoxBuscarNomeCliente);
            groupBox1.Location = new Point(4, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 273);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 165);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(291, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(922, 508);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(labelTitulo);
            Controls.Add(dataGridViewBuscarClientes);
            Controls.Add(pictureBox1);
            Name = "Vendas";
            Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuscarClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label labelErro;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button buttonConcluirPedido;
        private DataGridView dataGridViewBuscarClientes;
        private ComboBox comboBoxOpcaoPagamento;
        private TextBox textBoxValorFinal;
        private CheckBox checkBoxPagamento;
        private Label labelTitulo;
        private Label labelFormaDePag;
        private Label labelValorTotal;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}