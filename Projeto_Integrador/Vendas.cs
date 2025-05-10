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

        private void buttonConcluirPedido_Click(object sender, EventArgs e)
        {
            HairSharp novoForm = new HairSharp();
            novoForm.ShowDialog();
        }

       
    }
}
