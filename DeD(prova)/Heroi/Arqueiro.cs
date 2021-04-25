using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_.Classes
{
    class Arqueiro : Heroi
    {
        public Arqueiro(string nome, int level, string nomeclasse) :
             base(nome, level, nomeclasse)
        {

        }
        public override void Ataque(Monstro monstro)
        {
            Random rand = new Random();
            float ataque = (this.Status.Forca + this.Status.Agilidade) * (1 + (rand.Next(0, this.Status.Sorte) / 100));
            monstro.RecebeAtaque(ataque);
        }
        public override void AtaqueEspecial(Monstro monstro)
        {
            if (this.Status.Mana < 50)
            {
                System.Windows.Forms.MessageBox.Show("Mana insuficiente");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Você Atira uma flecha divina no céu, que cria uma chuva de flechas!!!");
                monstro.RecebeAtaque(300);
                this.Status.Mana -= 50;
            }

        }
    }
}
