using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora___2
{
    public partial class Novo_Form : Form
    {
        public Novo_Form()
        {
            InitializeComponent();
        }

        private void comboBoxFormas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFormas.SelectedItem)
            {
                case "Quadrado":
                    break;
                case "Retângulo":
                    break;
            }


        }

        private void comboBoxCalculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxCalculo.SelectedItem)
            {
                case "Área":
                    labelBase.Visible = true;
                    textBoxbase.Visible = true;
                    labelAltura.Visible = true;
                    textBoxaltura.Visible = true;

                    string Base = textBoxbase.Text;
                    string Altura = textBoxaltura.Text;

                    double doublebase = Convert.ToDouble(Base);
                    double doubleAltura = Convert.ToDouble(Altura);
                    double resultado;

                    if (doublebase > 0 && doubleAltura > 0)
                    {
                        doublebase * doubleAltura = resultado;
                    }
                    else
                    {
                        labelErro.Text = "O valor não pode ser zero!";
                    }
                    break;

                case "Perímetro":
                    labelBase.Visible = true;
                    textBoxbase.Visible = true;
                    labelAltura.Visible = true;
                    textBoxaltura.Visible = true;
                    break;

                case "Volume":
                    break;
            }
           
        }

        
    }
}
