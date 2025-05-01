using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {

        }
        private void buttonConcluirPedido_Click(object sender, EventArgs e)
        {
            Fiscalização_dos_Pedidos novoForm = new Fiscalização_dos_Pedidos();
            novoForm.ShowDialog();
        }
    }
}
