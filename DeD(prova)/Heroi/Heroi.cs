using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_.Classes
{
    public abstract class Heroi
    {
        public string Nome { get; set; }
        public int Level { get; set; }
        public Status Status { get; set; }
        public string NomeClasse { get; set; }

        public Heroi(string nome, int level,string nomeclasse)
        {
            this.Nome = nome;
            this.Level = level;
            this.NomeClasse = nomeclasse;
        }

        public float Defesa()
        {
            Random rand = new Random();
            float def = (this.Status.Defesa + this.Status.Agilidade) * (1 + (rand.Next(0, this.Status.Sorte) / 100));
            return def;
        }

        public abstract void Ataque(Monstro mostro);

        public void ReceberStatus(int forca, int defesa, int agilidade, int sorte, int vida, int mana)
        {
            this.Status = new Status(forca, defesa, agilidade, sorte, vida, mana);
        }

        public void RecebeAtaque(float valordano) //6
        {
            float Dano = (valordano/this.Defesa());
            if (Dano > 0)
            {
                this.Status.Vida -= Dano;
            }
        }

    }
}
