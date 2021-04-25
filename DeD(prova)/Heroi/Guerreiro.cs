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
            float sça = rand.Next(0, this.Status.Sorte);
            float ataque = (this.Status.Forca + this.Status.Agilidade) * (1 + (sça) / 100);
            monstro.RecebeAtaque(ataque);
        }

        public override void AtaqueEspecial(Monstro monstro)
        {
            if (this.Status.Mana < 30)
            {
                System.Windows.Forms.MessageBox.Show("Mana insuficiente");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Você avança no monstro com seu escudo, atordoando-o!Ele não consegue te atacar por 1 turno");
                monstro.RecebeAtaque(20);
                this.Status.Mana -= 30; 
            }

        }
    }
}
