using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_em_Equipe.Dominio
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime dataEntrada { get; set; }

        public string Validacoes()
        {
            if (Id < 0)
            {
                return "Id não pode ser negativo";
            }

            if (string.IsNullOrWhiteSpace(Nome))
            {
                return "O campo Nome é obrigatório";
            }

            if (!Nome.Contains(' '))
            {
                return "O campo Nome deve conter nome e sobrenome";
            }

            if (dataEntrada > DateTime.Today)
            {
                return "O campo Data de Nascimento deve ser uma data no passado";
            }

            return string.Empty;
        }
    }
}
