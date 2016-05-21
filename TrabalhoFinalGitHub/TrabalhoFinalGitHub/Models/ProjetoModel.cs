using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinalGitHub.Models
{
    class ProjetoModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tecnologia { get; set; }

        public ProjetoModel(string nome, string descricao, string tecnologia)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Tecnologia = tecnologia;
        }

    }
}
