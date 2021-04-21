using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_.Classes
{
    class Guerreiro : Heroi
    {

        public Guerreiro(string nome, int level,string nomeclasse) :
             base(nome, level, nomeclasse)
        {

        }
        public override void Ataque(Monstro monstro)
        {
            Random rand = new Random();
            float ataque = (this.Status.Forca + this.Status.Agilidade) * (1 + (rand.Next(0, this.Status.Sorte) / 100));
            monstro.RecebeAtaque(ataque);
        }
    }
}
