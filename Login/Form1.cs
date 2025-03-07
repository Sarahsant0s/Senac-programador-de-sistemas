using System.Text.RegularExpressions;

namespace Login
{
    public partial class Form1 : Form
    {
        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo vittar", "sukuna.silva" };
        List<string> listaSenhas = new List<string>() { "Bruna", "12345", "777" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

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
                labelResultado.Text = "Usu�rio ou senha incorretos...";
                labelResultado.ForeColor = Color.Red;
            }


        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            string novousuario = NovoUsuario.Text;
            string novasenha = this.novasenha.Text;
            bool usuarioencontrado = false;

            for (int i = 0; i < listaUsuarios.Count; i++) 
            { 
                if (novousuario == listaUsuarios[i])
                {
                    usuarioencontrado = true;
                }

            }
             
            if (usuarioencontrado == false)
            {
                listaUsuarios.Add(novousuario);
                listaSenhas.Add(novasenha);
                labelNovoUsuario.Text = "Usu�rio cadastrado com sucesso!";
                labelNovoUsuario.ForeColor = Color.Green;
            }
            else
            {
                labelNovoUsuario.Text = "J� existe um usu�rio cadastrado!";
                labelNovoUsuario.ForeColor = Color.Red;
            }
            if (!Regex.IsMatch(novasenha, @"[0-9]"))
                labelNovoUsuario.Text = "A senha deve conter pelo menos 1 n�mero.";

            if (!Regex.IsMatch(novasenha, @"[!@#$%^&*(),.?""{}|<>]"))
                labelNovoUsuario.Text = "A senha deve conter pelo menos 1 caractere especial.";

            if (!Regex.IsMatch(novasenha, @"[A-Z]"))
                labelNovoUsuario.Text = "A senha deve conter pelo menos 1 letra mai�scula.";

            if (!Regex.IsMatch(novasenha, @"[a-z]"))
                labelNovoUsuario.Text = "A senha deve conter pelo menos 1 letra min�scula.";

            if (novasenha.Contains(" "))
                labelNovoUsuario.Text = "A senha n�o pode conter espa�os.";

        }
    }
}
