namespace Trabalho_em_Equipe
{
    partial class Cadastro_Produto
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
            dataGridViewCadastro = new DataGridView();
            buttonCadastrar = new Button();
            buttonRemover = new Button();
            textBoxNomeProduto = new TextBox();
            maskedTextBoxDataProduto = new MaskedTextBox();
            labelProduto = new Label();
            textBox1 = new TextBox();
            labelQuantidade = new Label();
            labelDataEntrada = new Label();
            labelErro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastro).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCadastro
            // 
            dataGridViewCadastro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCadastro.Location = new Point(32, 101);
            dataGridViewCadastro.Name = "dataGridViewCadastro";
            dataGridViewCadastro.Size = new Size(485, 334);
            dataGridViewCadastro.TabIndex = 1;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(601, 337);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 2;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(601, 366);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 3;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            // 
            // textBoxNomeProduto
            // 
            textBoxNomeProduto.Location = new Point(573, 119);
            textBoxNomeProduto.Name = "textBoxNomeProduto";
            textBoxNomeProduto.Size = new Size(139, 23);
            textBoxNomeProduto.TabIndex = 5;
            // 
            // maskedTextBoxDataProduto
            // 
            maskedTextBoxDataProduto.Location = new Point(601, 249);
            maskedTextBoxDataProduto.Mask = "00/00/0000";
            maskedTextBoxDataProduto.Name = "maskedTextBoxDataProduto";
            maskedTextBoxDataProduto.Size = new Size(75, 23);
            maskedTextBoxDataProduto.TabIndex = 6;
            maskedTextBoxDataProduto.ValidatingType = typeof(DateTime);
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProduto.Location = new Point(581, 101);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(109, 15);
            labelProduto.TabIndex = 8;
            labelProduto.Text = "Nome do Produto:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(573, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 9;
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuantidade.Location = new Point(573, 162);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(139, 15);
            labelQuantidade.TabIndex = 10;
            labelQuantidade.Text = "Quantidade do Produto:";
            // 
            // labelDataEntrada
            // 
            labelDataEntrada.AutoSize = true;
            labelDataEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDataEntrada.Location = new Point(590, 231);
            labelDataEntrada.Name = "labelDataEntrada";
            labelDataEntrada.Size = new Size(96, 15);
            labelDataEntrada.TabIndex = 11;
            labelDataEntrada.Text = "Data de entrada";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(32, 72);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(10, 15);
            labelErro.TabIndex = 12;
            labelErro.Text = ".";
            // 
            // Cadastro_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelErro);
            Controls.Add(labelDataEntrada);
            Controls.Add(labelQuantidade);
            Controls.Add(textBox1);
            Controls.Add(labelProduto);
            Controls.Add(maskedTextBoxDataProduto);
            Controls.Add(textBoxNomeProduto);
            Controls.Add(buttonRemover);
            Controls.Add(buttonCadastrar);
            Controls.Add(dataGridViewCadastro);
            Name = "Cadastro_Produto";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCadastro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCadastro;
        private Button buttonCadastrar;
        private Button buttonRemover;
        private TextBox textBoxNomeProduto;
        private MaskedTextBox maskedTextBoxDataProduto;
        private Label labelProduto;
        private TextBox textBox1;
        private Label labelQuantidade;
        private Label labelDataEntrada;
        private Label labelErro;
    }
}
