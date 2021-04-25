using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_.Classes
{
    class Mago : Heroi
    {
        public Mago(string nome,int level, string nomeclasse) :
             base(nome,level,nomeclasse)
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
            if (this.Inventario.Direita.NomeItem == "Cajado Boreal")
            {
                if(this.Status.Mana < 20)
                {
                    System.Windows.Forms.MessageBox.Show("Mana insuficiente");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Você se cura, gastando sua mana!");
                    this.Status.Mana -= 20;
                    this.Status.Vida += 50;
                }

            }
            else
            {
                if (this.Status.Mana < 50)
                {
                    System.Windows.Forms.MessageBox.Show("Mana insuficiente");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Você conjura uma magia antiga ancestral, onde você sobe 10 Níveis!!");
                    this.Status.Mana -= 50;
                    Status.MelhorarStatus(10);
                }
            }
        }
    }
}
