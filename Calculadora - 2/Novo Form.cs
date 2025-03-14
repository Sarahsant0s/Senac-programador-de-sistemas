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
    public partial class radioButtonCompri : Form
    {
        public radioButtonCompri()
        {
            InitializeComponent();
        }

        private void comboBoxFormas_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            if (comboBoxFormas_SelectedItem.ToString)
            {

            }
            switch (comboBoxFormas.SelectedItem)
            {
                case "Quadrado":
                    break;
                case "Retângulo":
                    break;
            }
            */

        }

        private void comboBoxCalculo_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            switch (comboBoxCalculo.SelectedItem)
            {
                case "Área":
                    labelBase.Visible = true;
                    textBoxLargura.Visible = true;
                    labelAltura.Visible = true;
                    textBoxaltura.Visible = true;
                    break;

                case "Perímetro":
                    labelBase.Visible = true;
                    textBoxLargura.Visible = true;
                    labelAltura.Visible = true;
                    textBoxaltura.Visible = true;
                    break;

                case "Volume":
                    break;
            }
            */
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string Base = textBoxLargura.Text;
            string Altura = textBoxaltura.Text;

            double doublebase = Convert.ToDouble(Base);
            double doubleAltura = Convert.ToDouble(Altura);
            double resultado;

            if (doublebase > 0 && doubleAltura > 0)
            {
                resultado = doublebase * doubleAltura;
            }
            else
            {
                labelErro.Text = "O valor não pode ser zero!";
            }
        }

        private void buttonnovoform_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }
    }
}

