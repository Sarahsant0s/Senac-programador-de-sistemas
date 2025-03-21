namespace Cadastro_Cliente
{
    public partial class Form1 : Form
    {
        List<ClassCliente> clientes = new List<ClassCliente>();
        private readonly BindingSource BindingSource = [];
        public Form1()
        {
            InitializeComponent();
            EnderecoCliente enderecocliente1 = new EnderecoCliente() { logradouro = "Rua Luiza Carioba", numero = "72", complemento = "", bairro = "Jardim Monte Verde", municipio = "S�o Paulo", estado = "S�o Paulo", cep = "04851-519" };
            EnderecoCliente enderecocliente2 = new EnderecoCliente() { logradouro = "Rua Pera Natal", numero = "140", complemento = "", bairro = "Jardim S�o Bernardo", municipio = "S�o Paulo", estado = "S�o Paulo", cep = "04863-320" };
            EnderecoCliente enderecocliente3 = new EnderecoCliente() { logradouro = "Rua Joaquim Pires", numero = "165", complemento = "", bairro = "Vila Narciso", municipio = "S�o Paulo", estado = "S�o Paulo", cep = "04851-803" };
            clientes.Add(new ClassCliente() { id = 1, nome = "Sarah", dataNascimento = "24/01/2006", telefone = "(11) 97737-3074", email = "Sarahcosta8989@email.com", nomesocial = "N�o se aplica", endereco = enderecocliente1, estrangeiro = false, tipo = TipoCliente.PF, genero = GeneroCliente.Feminino, Etnia = EtniaCliente.Negro, });
            clientes.Add(new ClassCliente() { id = 2, nome = "Leticia", dataNascimento = "09/03/2004", telefone = "(11) 94002-8922", email = "letciapurple@email.com", nomesocial = "N�o se aplica", endereco = enderecocliente2, estrangeiro = false, tipo = TipoCliente.PF, genero = GeneroCliente.Feminino, Etnia = EtniaCliente.Branco, });
            clientes.Add(new ClassCliente() { id = 3, nome = "Claudia", dataNascimento = "06/03/1989", telefone = "(11) 97951-1319", email = "Claudiasantosdecor@email.com", nomesocial = "N�o se aplica", endereco = enderecocliente3, estrangeiro = false, tipo = TipoCliente.PF, genero = GeneroCliente.Feminino, Etnia = EtniaCliente.Branco, });

            BindingSource.DataSource = clientes;
            dataGridViewClientes.DataSource = BindingSource;
        }

            public bool LimparErro()
        {
            labelErro.Text = "";
            return true;
        }
        public bool Validacoes()
        {
            string nomeCliente = textBoxnome.Text;
            string DataNascCliente = maskedTextBoxnascimento.Text;
            string telefoneCliente = maskedTextBoxtelefone.Text;
            string emailCliente = textBoxemail.Text;
            string logradouroCliente = textBoxLogradouro.Text;
            string numeroCliente = textBoxnumero.Text;
            string bairroCliente = textBoxbairro.Text;
            string municipioCliente = textBoxmunicipio.Text;
            string cepCliente = maskedTextBoxCep.Text;


            if (string.IsNullOrWhiteSpace(nomeCliente))
            {
                labelErro.Text = "O nome � obrigat�rio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (nomeCliente.Any(char.IsNumber))
            {
                labelErro.Text = "O Nome s� pode conter letras!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            if (DataNascCliente == "  /  /    " || DataNascCliente.Length < 10)
            {
                labelErro.Text = "A Data de Nascimento � obrigat�ria!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            if (telefoneCliente == "(  )      -    " || telefoneCliente.Length < 15)
            {
                labelErro.Text = "O Telefone � obrigat�rio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            if (string.IsNullOrWhiteSpace(emailCliente))
            {
                labelErro.Text = "O Email � obrigat�rio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!emailCliente.EndsWith("@email.com"))
            {
                labelErro.Text = "O Email deve conter @email.com!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            if (comboBoxGenero.SelectedItem == null)
            {
                labelErro.Text = "Selecione um g�nero!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            if (comboBoxEtnia.SelectedItem == null)
            {
                labelErro.Text = "Selecione uma etnia!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            if (!checkBoxsim.Checked && !checkBoxnao.Checked)
            {
                labelErro.Text = "Selecione uma op��o!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            if (!radioButtonPF.Checked && !radioButtonPJ.Checked)
            {
                labelErro.Text = "Selecione um Tipo de Cliente!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            if (string.IsNullOrWhiteSpace(logradouroCliente))
            {
                labelErro.Text = "O Logradouro � obrigat�rio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            if (string.IsNullOrWhiteSpace(numeroCliente))
            {
                labelErro.Text = "O N�mero � obrigat�rio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (numeroCliente.All(char.IsLetter))
            {
                labelErro.Text = "O N�mero n�o pode s� conter letras!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            if (string.IsNullOrWhiteSpace(bairroCliente))
            {
                labelErro.Text = "O Bairro � obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (bairroCliente.Any(char.IsNumber))
            {
                labelErro.Text = "O Bairro n�o pode conter n�meros!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            if (string.IsNullOrWhiteSpace(municipioCliente))
            {
                labelErro.Text = "O Munic�pio � obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (municipioCliente.Any(char.IsNumber))
            {
                labelErro.Text = "O Munic�pio n�o pode conter numeros!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            if (comboBoxestado.SelectedItem == null)
            {
                labelErro.Text = "Selecione um Estado!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            if (cepCliente == "     -   " || cepCliente.Length < 9)
            {
                labelErro.Text = "O CEP � obrigat�rio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            if (!checkBoxTermo.Checked)
            {
                labelErro.Text = "Voc� precisa aceitar os Termos e condi��es para prosseguir com o procedimento!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (!LimparErro())
            {
                return;
            }
            if (!Validacoes())
            {
                return;
            }

            string emailCliente = textBoxemail.Text;
            string telefoneCliente = maskedTextBoxtelefone.Text;
            int ClienteCadastrado = -1;

            for (int i = 0; i < clientes.Count; i++)
            {
                if (emailCliente == clientes[i].email || telefoneCliente == clientes[i].telefone)
                {
                    ClienteCadastrado = i;
                }
            }
            if (ClienteCadastrado > -1)
            {
                labelResultado.Text = "Cliente j� cadastrado!";
            }
            else
            {
                labelResultado.Text = "Cliente Cadastrado com sucesso!";
            }
        }
    }
}
