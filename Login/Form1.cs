namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usu�rio = textBoxUsu�rio.Text;
            string senha = textBoxSenha.Text;

            if (usu�rio == null || usu�rio == "")
            {
                labelResultado.Text = "Usu�rio � obrigat�rio!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (usu�rio == "Sarah" && senha == "12345")
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
