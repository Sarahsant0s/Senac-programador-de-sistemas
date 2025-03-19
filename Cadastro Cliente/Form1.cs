namespace Cadastro_Cliente
{
    public partial class Form1 : Form
    {
        List<ClassCliente> clientes = new List<ClassCliente>();
        public Form1()
        {
            InitializeComponent();
            EnderecoCliente enderecocliente1 = new EnderecoCliente() { logradouro = "Rua Luiza Carioba", numero = "72", complemento = "", bairro = "Jardim Monte Verde", municipio = "São Paulo", estado = "São Paulo", cep = "04851-519" };
            EnderecoCliente enderecocliente2 = new EnderecoCliente() { logradouro = "Rua Pera Natal", numero = "140", complemento = "", bairro = "Jardim São Bernardo", municipio = "São Paulo", estado = "São Paulo", cep = "04863-320" };
            EnderecoCliente enderecocliente3 = new EnderecoCliente() { logradouro = "Rua Joaquim Pires", numero = "165", complemento = "", bairro = "Vila Narciso", municipio = "São Paulo", estado = "São Paulo", cep = "04851-803" };
            clientes.Add(new ClassCliente() { id = 1, nome = "Sarah", dataNascimento = "24/01/2006", telefone = "(11) 97737-3074", email = "Sarahcosta8989@gmail.com", nomesocial = "Não se aplica", endereco = enderecocliente1, estrangeiro = false, tipo = TipoCliente.PF, genero = GeneroCliente.Feminino, Etnia = EtniaCliente.Negro, });
            clientes.Add(new ClassCliente() { id = 2, nome = "Leticia", dataNascimento = "09/03/2004", telefone = "(11) 94002-8922", email = "letciapurple@gmail.com", nomesocial = "Não se aplica", endereco = enderecocliente2, estrangeiro = false, tipo = TipoCliente.PF, genero = GeneroCliente.Feminino, Etnia = EtniaCliente.Branco, });
            clientes.Add(new ClassCliente() { id = 3, nome = "Claudia", dataNascimento = "06/03/1989", telefone = "(11) 97951-1319", email = "Claudiasantosdecor@gmail.com", nomesocial = "Não se aplica", endereco = enderecocliente3, estrangeiro = false, tipo = TipoCliente.PF, genero = GeneroCliente.Feminino, Etnia = EtniaCliente.Branco, });
        }

        

    }
}
