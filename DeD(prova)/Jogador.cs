using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_
{
    public class Jogador
    {
        public string Nome { get; set; }
        public int Level { get; set; }
        public Status Status { get; set; }
        public string Classe { get; set; }

        public Jogador(string nome, int level, string classe)
        {
            this.Nome = nome;
            this.Level = level;
            this.Classe = classe;
        }

    }
}
