using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Login
{
    public partial class Form1 : Form
    {
        private static readonly string Connectionstring = "datasource=localhost;usename=root;password=;database=senac;";
        private readonly MySqlConnection Connection = new MySqlConnection(Connectionstring);

        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = textBoxUsu�rio.Text;
            string senha = textBoxSenha.Text;

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = " O Usu�rio � obrigat�rio!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (senha == null || senha == "")
            {
                labelResultado.Text = "A senha � obrigat�ria!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            bool autenticado = false;

            try
            {
                Connection.Open();

                string query = $"SELECT senha FROM usuario WHERE email = '{usuarioBuscado}';";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                autenticado = reader.Read() && reader.GetString(0) == senha;
            }

            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }

            finally
            {
                Connection.Close();
            }


            if (!autenticado)
            {
                labelResultado.Text = "Autenticado com sucesso!";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "Usu�rio ou senha incorretos...";
                labelResultado.ForeColor = Color.Red;
            }


        }


        private void buttonCadastrar_Click_1(object sender, EventArgs e)
        {
            string novousuario = NovoUsuario.Text;
            string novasenha = novaSenha.Text;

            if (string.IsNullOrWhiteSpace(novousuario))
            {
                labelResultado.Text = "O usuario � obrigat�rio!!!";
                return;
            }

            if (string.IsNullOrWhiteSpace(novasenha))
            {
                labelResultado.Text = " A senha � obrigat�ria!!!";
                return;
            }


            if (novasenha.Length < 8)
            {
                labelResultado.Text = "A senha deve conter pelo menos 8 caracteres";
                return;
            }

            if (!novasenha.Any(char.IsUpper))
            {
                labelResultado.Text = "A senha deve conter pelo menos uma letra mai�scula";
                return;
            }

            if (!novasenha.Any(char.IsLower))
            {
                labelResultado.Text = "A senha deve conter pelo menos uma letra min�scula";
                return;
            }

            if (!novasenha.Any(char.IsDigit))
            {
                labelResultado.Text = "A senha deve conter pelo menos um n�mero";
                return;
            }

            if (!novasenha.Any(char.IsPunctuation))
            {
                labelResultado.Text = "A senha deve conter pelo menos um caracter especial!";
                return;
            }

            if (novasenha.Contains(' '))
            {
                labelResultado.Text = "A senha n�o deve ter espacos em branco.";
                return;
            }

            bool encontrado = false;

            try
            {
                Connection.Open();

                string query = $"SELECT email FROM usuario WHERE email = '{novousuario}';";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                encontrado = reader.Read();
            }

            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }

            finally
            {
                Connection.Close();
            }


            if (!encontrado)
            {
                labelResultado.Text = "J� existe um usu�rio cadastrado.";
                return;
            }

            try
            {
                Connection.Open();

                string query = $"INSERT INTO usuarios (email, senha) VALUES ('{novousuario}','{novasenha}');";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                mySqlCommand.ExecuteNonQuery();

                labelResultado.Text = "Usu�rio cadastrado com sucesso!";
            }

            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }

            finally
            {
                Connection.Close();
            }

            NovoUsuario.Clear();
            novaSenha.Clear();
        }
    }

}

