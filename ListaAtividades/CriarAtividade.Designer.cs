namespace ListaAtividades
{
    partial class CriarAtividade
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
            buttondescartar = new Button();
            buttonCriar = new Button();
            labelTitulo = new Label();
            labelErro = new Label();
            textBoxTitulo = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttondescartar
            // 
            buttondescartar.Location = new Point(318, 264);
            buttondescartar.Name = "buttondescartar";
            buttondescartar.Size = new Size(75, 23);
            buttondescartar.TabIndex = 0;
            buttondescartar.Text = "Descartar";
            buttondescartar.UseVisualStyleBackColor = true;
            buttondescartar.Click += buttondescartar_Click;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(410, 264);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(75, 23);
            buttonCriar.TabIndex = 1;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(380, 217);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(37, 15);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "Título";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(6, 406);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 3;
            labelErro.Text = "label2";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(346, 235);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(100, 23);
            textBoxTitulo.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelTitulo);
            groupBox1.Controls.Add(labelErro);
            groupBox1.Controls.Add(textBoxTitulo);
            groupBox1.Controls.Add(buttonCriar);
            groupBox1.Controls.Add(buttondescartar);
            groupBox1.Location = new Point(9, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(779, 424);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // CriarAtividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "CriarAtividade";
            Text = "CriarAtividade";
            Load += CriarAtividade_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttondescartar;
        private Button buttonCriar;
        private Label labelTitulo;
        private Label labelErro;
        private TextBox textBoxTitulo;
        private GroupBox groupBox1;
    }
}