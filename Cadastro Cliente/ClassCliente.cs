using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Cliente
{
    internal class ClassCliente
    {
        public int id {  get; set; }
        public string nome { get; set; }
        public string dataNascimento { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }

        public EnderecoCliente endereco { get; set; }
        public GeneroCliente genero { get; set; }
        public string nomesocial { get; set; }
        public EtniaCliente Etnia { get; set; }
        public bool estrangeiro { get; set; }
        public TipoCliente tipo { get; set; }
        
    }
}
