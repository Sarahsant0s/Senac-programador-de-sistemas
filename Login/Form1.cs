using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Login
{
    public partial class Form1 : Form
    {
        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo vitar", "sukuna.silva" };
        List<string> listaSenhas = new List<string>() { "Bruna@123", "12345Abc", "Sete7Sete" };

        Usuario neymar = new Usuario() { Email = "neymar.jr@email.com", Senha = "Bruna@123" };
        Usuario pablo = new Usuario() { Email = "pablo.vitar2email.com", Senha = "12345Abc" };
        Usuario sukuna = new Usuario() { Email = "sukuna.silva@email.com", Senha = "Sete7Sete" };

        List<Usuario> usuario = new List<Usuario>();


        public Form1()
        {
            InitializeComponent();
            usuario.Add(neymar);
            usuario.Add(pablo);
            usuario.Add(sukuna);
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = textBoxUsuário.Text;
            string senha = textBoxSenha.Text;

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = " O Usuário é obrigatório!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (senha == null || senha == "")
            {
                labelResultado.Text = "A senha é obrigatória!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            int posicaoUsuarioEncontrado = -1;

            for (int i = 0; i < listaUsuarios.Count; i++)
            {

                if (usuarioBuscado == listaUsuarios[i])
                {
                    posicaoUsuarioEncontrado = i;
                }
            }



            if (posicaoUsuarioEncontrado > -1 && senha == listaSenhas[posicaoUsuarioEncontrado])
            {
                labelResultado.Text = "Autenticado com sucesso!";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "Usuário ou senha incorretos...";
                labelResultado.ForeColor = Color.Red;
            }


        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string novousuario = NovoUsuario.Text;
            string novasenha = novaSenha.Text;

            if (string.IsNullOrWhiteSpace(novousuario))
            {
                labelResultado.Text = "O usuario é obrigatório!!!";
                return;
            }

            if (string.IsNullOrWhiteSpace(novasenha))
            {
                labelResultado.Text = " A senha é obrigatória!!!";
                return;
            }
             

            if (novasenha.Length < 8)
            {
                labelResultado.Text = "A senha deve conter pelo menos 8 caracteres";
                return;
            }

            if (!novasenha.Any(char.IsUpper))
            {
                labelResultado.Text = "A senha deve conter pelo menos uma letra maiúscula";
                return;
            }

            if (!novasenha.Any(char.IsLower))
            {
                labelResultado.Text = "A senha deve conter pelo menos uma letra minúscula";
                return;
            }

            if (!novasenha.Any(char.IsDigit))
            {
                labelResultado.Text = "A senha deve conter pelo menos um número";
                return;
            }

            if (!novasenha.Any(char.IsPunctuation))
            {
                labelResultado.Text = "A senha deve conter pelo menos um caracter especial!";
                return;
            }

            if (novasenha.Contains(' '))
            {
                labelResultado.Text = "A senha não deve ter espacos em branco.";
                return;
            }

            if (listaUsuarios.Contains(novousuario))
            {
                labelResultado.Text = "Já existe um usuário cadastrado.";
                return;
            }

            listaUsuarios.Add(novousuario);
            listaSenhas.Add(novasenha);
            labelResultado.Text = "Usuário cadastrado com sucesso!";
            NovoUsuario.Clear();
            novaSenha.Clear();
        }

    }

}

