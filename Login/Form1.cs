namespace Login
{
    public partial class Form1 : Form
    {
        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo vittar", "sukuna.silva" };

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


              
            if (posicaoUsuarioEncontrado > -1 && senha == "12345")
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

    }
}
