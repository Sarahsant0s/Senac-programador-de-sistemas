using System.Security.Cryptography;

namespace Projeto_Integrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendas novoForm = new Vendas();
            novoForm.ShowDialog();

            this.Close();
        }
    }
}
