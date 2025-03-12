namespace Calculadora___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonCalcular_Click(object sender, EventArgs e)
        {
            string valor1 = textboxValor1.Text;
            string valor2 = textboxValor2.Text;

            if (!valor1.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 1 deve ser um número.";
                return;
            }


            double doubleValor1 = Convert.ToDouble(valor1);
            double doubleValor2 = Convert.ToDouble(valor2);

            double resultado = doubleValor1 + doubleValor2;

            textboxValor.Text = resultado.ToString();
        }

        private void radiButtondivi_Click(object sender, EventArgs e)
        {
            string valor1 = textboxValor1.Text;
            string valor2 = textboxValor2.Text;

            if (!valor1.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 1 deve ser um número.";
                return;
            }


            double doubleValor1 = Convert.ToDouble(valor1);
            double doubleValor2 = Convert.ToDouble(valor2);

            double resultado = doubleValor1 / doubleValor2;

            textboxValor.Text = resultado.ToString();
        }

        private void radioButtonmenos_Click(object sender, EventArgs e)
        {
            string valor1 = textboxValor1.Text;
            string valor2 = textboxValor2.Text;

            if (!valor1.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 1 deve ser um número.";
                return;
            }


            double doubleValor1 = Convert.ToDouble(valor1);
            double doubleValor2 = Convert.ToDouble(valor2);

            double resultado = doubleValor1 - doubleValor2;

            textboxValor.Text = resultado.ToString();
        }

        private void radioButtonmult_Click(object sender, EventArgs e)
        {
            string valor1 = textboxValor1.Text;
            string valor2 = textboxValor2.Text;

            if (!valor1.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 1 deve ser um número.";
                return;
            }
            if (!valor2.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 2 deve ser um número.";
                return;
            }


            double doubleValor1 = Convert.ToDouble(valor1);
            double doubleValor2 = Convert.ToDouble(valor2);

            double resultado;



            switch (comboBox1.SelectedItem?.ToString())
            {
                case "Soma":
                    resultado = doubleValor1 + doubleValor2;
                    break;
                case "Subtrair":
                    resultado = doubleValor1 - doubleValor2;
                    break;
                case "Dividir":
                    if (doubleValor1 != 0 || doubleValor2 != 0)
                    {
                        resultado = doubleValor1 / doubleValor2;
                    }
                    else
                    {
                        labelResultado.Text = "Não é possível efetuar a divisão com valor zero!";
                    }
                    break;
                case "Multiplicar":
                    resultado = doubleValor1 * doubleValor2;
                    break;
                default:
                    labelResultado.Text = "Escolhe caralho!";
                    break;

            }



        }

        private void buttonresultado_Click(object sender, EventArgs e)
        {
            string valor1 = textboxValor1.Text;
            string valor2 = textboxValor2.Text;

            if (!valor1.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 1 deve ser um número.";
                return;
            }
            if (!valor2.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 2 deve ser um número.";
                return;
            }


            double doubleValor1 = Convert.ToDouble(valor1);
            double doubleValor2 = Convert.ToDouble(valor2);

            double resultado;


            switch (comboBox1.SelectedItem?.ToString())
            {
                case "Somar":
                    resultado = doubleValor1 + doubleValor2;
                    textboxValor.Text = resultado.ToString();
                    break;
                case "Subtrair":
                    resultado = doubleValor1 - doubleValor2;
                    textboxValor.Text = resultado.ToString();
                    break;
                case "Dividir":
                    if (doubleValor1 != 0 || doubleValor2 != 0)
                    {
                        resultado = doubleValor1 / doubleValor2;
                        textboxValor.Text = resultado.ToString();
                    }
                    else
                    {
                        labelResultado.Text = "Não é possível efetuar a divisão com valor zero!";
                    }
                    break;
                case "Multiplicar":
                    resultado = doubleValor1 * doubleValor2;
                    textboxValor.Text = resultado.ToString();
                    break;
                    /*default:
                        labelResultado.Text = "Escolha um valor!";
                        break;*/

            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem?.ToString())
            {
                case "Somar":
                    labelsinal.Text = "+";
                    break;
                case "Subtrair":
                    labelsinal.Text = "-";
                    break;
                case "Dividir":
                    labelsinal.Text = "/";
                    break;
                case "Multiplicar":
                    labelsinal.Text = "*";
                    break;
            }

        }

        private void buttonnovoform_Click(object sender, EventArgs e)
        {
            Novo_Form novoForm = new Novo_Form();
            novoForm.Show();

            this.Hide();
        }
    }
}
