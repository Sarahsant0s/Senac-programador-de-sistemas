namespace Trabalho_em_Equipe
{
    partial class Alteracao
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
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            dataGridViewAlteracao = new DataGridView();
            textBox1 = new TextBox();
            labelErro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlteracao).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(573, 278);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(147, 23);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "Adicionar Produto";
            buttonAdicionar.UseVisualStyleBackColor = true;
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(573, 340);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(147, 23);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "Remover Produto";
            buttonRemover.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAlteracao
            // 
            dataGridViewAlteracao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlteracao.Location = new Point(31, 55);
            dataGridViewAlteracao.Name = "dataGridViewAlteracao";
            dataGridViewAlteracao.Size = new Size(495, 362);
            dataGridViewAlteracao.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(591, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(31, 19);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(10, 15);
            labelErro.TabIndex = 4;
            labelErro.Text = ".";
            // 
            // Alteracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelErro);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewAlteracao);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            Name = "Alteracao";
            Text = "Alteracao";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlteracao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdicionar;
        private Button buttonRemover;
        private DataGridView dataGridViewAlteracao;
        private TextBox textBox1;
        private Label labelErro;
    }
}