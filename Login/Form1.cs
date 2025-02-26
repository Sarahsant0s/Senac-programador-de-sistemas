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
            string usuário = textBoxUsuário.Text;
            string senha = textBoxSenha.Text;

            if (usuário == null || usuário == "")
            {
                labelResultado.Text = "Usuário é obrigatório!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (usuário == "Sarah" && senha == "12345")
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

    }
}
