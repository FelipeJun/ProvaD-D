using DeD_prova_.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_.Monstros
{
    class Slime : Monstro
    {
        public Slime() : base("Slime", CriaStatus(), "Imagens\\slime.png",15)
        {
            
        }

        public static Status CriaStatus()
        {
           return new Status(5,1,1,1,200,1);
        }

        public override void Ataque(Heroi heroi)
        {
            Random rand = new Random();
            float ataque = (this.Status.Forca + this.Status.Agilidade) * (1 + (rand.Next(0, this.Status.Sorte) / 100));
            heroi.RecebeAtaque(ataque);
        }
    }
}
