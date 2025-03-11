namespace Calculadora___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
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

            labelValor.Text = resultado.ToString();
        }

        private void buttondivi_Click(object sender, EventArgs e)
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

            labelValor.Text = resultado.ToString();
        }

        private void buttonmenos_Click(object sender, EventArgs e)
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

            labelValor.Text = resultado.ToString();
        }

        private void buttonmult_Click(object sender, EventArgs e)
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

            double resultado = doubleValor1 * doubleValor2;

            labelValor.Text = resultado.ToString();
        }
    }
}
