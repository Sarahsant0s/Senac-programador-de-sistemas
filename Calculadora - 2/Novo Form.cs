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
        private bool ValidarForm()
        {
            labelErro.Text = "";
            return false;
        }
        private void comboBoxFormas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFormas.SelectedItem == null)
            {
                labelErro.Text = "Selecione um opção";
                return;
            }

            if (comboBoxFormas.SelectedItem.ToString() == "Quadrado")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                return;
            }

            if (comboBoxFormas.SelectedItem.ToString() == "Retângulo")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                return;
            }
            if (comboBoxFormas.SelectedItem.ToString() == "Círculo")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                return;
            }

        }

        private void radioButtonPerimetro_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCompri.Enabled = false;
        }

        private void radioButtonArea_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCompri.Enabled = false;
        }

        private void radioButtonVolume_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCompri.Enabled = true;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            labelErro.Text = "";

            if (radioButtonPerimetro.Checked)
            {
                string largura = textBoxaltura.Text;
                string altura = textBoxaltura.Text;

                if (string.IsNullOrWhiteSpace(largura) || !largura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura valida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(altura) || !altura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma altura valida.";
                    return;
                }

                double resultado = (Convert.ToDouble(altura) * 2) + (Convert.ToDouble(largura) * 2);

                textBoxResultado.Text = resultado.ToString();
                return;
            }

            if (radioButtonÁrea.Checked)
            {
                string largura = textBoxaltura.Text;
                string altura = textBoxaltura.Text;

                if (string.IsNullOrWhiteSpace(largura) || !largura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura valida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(altura) || !altura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma altura valida.";
                    return;
                }

                double resultado = Convert.ToDouble(altura) * Convert.ToDouble(largura);

                textBoxResultado.Text = resultado.ToString();
                return;
            }

            if (radioButtonVol.Checked)
            {
                string largura = textBoxLargura.Text;
                string altura = textBoxaltura.Text;
                string comprimento = textBoxCompri.Text;

                if (string.IsNullOrWhiteSpace(largura) || !largura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura valida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(altura) || !altura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma altura valida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(comprimento) || !comprimento.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma comprimento valida.";
                    return;
                }

                double resultado = Convert.ToDouble(altura) * Convert.ToDouble(largura) * Convert.ToDouble(comprimento);

                textBoxResultado.Text = resultado.ToString();
                return;
            }


        }

        private void buttonnovoform_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!radioButtonarea3.Checked &&
                !radioButtondiametro.Checked &&
                !radioButtonperi3.Checked &&
                !radioButtonvol3.Checked)
            {
                labelErro.Text = "Selecione uma opção.";
            }

            string raio = textBoxRaio.Text;

            if (string.IsNullOrWhiteSpace(raio) || raio.All(char.IsNumber))
            {
                labelErro.Text = "Insira um raio de um numero válido!";
                return;
            }
            double raioDoNumero = Convert.ToDouble(raio);
            double resultado;

            if (radioButtonarea3.Checked)
            {
                resultado = Math.PI * Math.Pow(raioDoNumero, 2);
                textBoxResultadoCirculo.Text = Math.Round(resultado).ToString();
                return;
            }

            if (radioButtondiametro.Checked)
            {
                resultado = 2 * raioDoNumero;
                textBoxResultadoCirculo.Text = Math.Round(resultado).ToString();
                return;
            }

            if (radioButtonperi3.Checked)
            {
                resultado = 2 * Math.PI * raioDoNumero;
                textBoxResultadoCirculo.Text = Math.Round(resultado).ToString();
                return;
            }
            if (radioButtonvol3.Checked)
            {
                resultado = (4 / 3) * Math.PI * Math.Pow(raioDoNumero, 3);
                textBoxResultadoCirculo.Text = Math.Round(resultado).ToString();
                return;
            }

        }

        private void buttonCalcularQua_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                string lado = textBoxlado.Text;

                if (string.IsNullOrWhiteSpace(lado) || !lado.All(char.IsNumber))
                {
                    labelErro.Text = "Insira um lado válido.";
                    return;
                }

                double resultado = Convert.ToDouble(lado) * Convert.ToDouble(lado);

                textBoxresultado2.Text = resultado.ToString();
                return;
            }

            if (radioButton2.Checked)
            {
                string lado = textBoxlado.Text;

                if (string.IsNullOrWhiteSpace(lado) || !lado.All(char.IsNumber))
                {
                    labelErro.Text = "Insira um lado válido.";
                    return;
                }

                double resultado = (Convert.ToDouble(lado) * 2) + (Convert.ToDouble(lado) * 2);

                textBoxresultado2.Text = resultado.ToString();
                return;
            }

            if (radioButton4.Checked)
            {
                string lado = textBoxlado.Text;
                

                if (string.IsNullOrWhiteSpace(lado) || !lado.All(char.IsNumber))
                {
                    labelErro.Text = "Insira um lado válido.";
                    return;
                }

                double resultado = Convert.ToDouble(lado) * Convert.ToDouble(lado) * Convert.ToDouble(lado);

                textBoxresultado2.Text = resultado.ToString();
                return;
            }
        }
    }
}

