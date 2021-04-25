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
        public Inventario Inventario { get; set; }
        public int Dinheiro { get; set; }

        public Heroi(string nome, int level,string nomeclasse)
        {
            this.Nome = nome;
            this.Level = level;
            this.NomeClasse = nomeclasse;
            this.Inventario = new Inventario();
            this.Dinheiro = 0;
        }

        public float Defesa()
        {
            Random rand = new Random();
            float def = (this.Status.Defesa + this.Status.Agilidade) * (1 + (rand.Next(0, this.Status.Sorte) / 100));
            return def;
        }

        public abstract void Ataque(Monstro monstro);

        public abstract void AtaqueEspecial(Monstro monstro);

        public void ReceberStatus(int forca, int defesa, int agilidade, int sorte, int vida, int mana)
        {
            this.Status = new Status(forca, defesa, agilidade, sorte, vida, mana);
        }


        public void RecebeAtaque(float valordano) 
        {
            float Dano = (this.Defesa()/100) - valordano;
            if (Dano < 0)
            {
                this.Status.Vida += Convert.ToInt32(Dano);
            }
        }

        public static void SubirLevel(Heroi player,Monstro monstro)
        {
            if(monstro.Nome == "Slime")
            {
                player.Level += 1;
                player.Status.MelhorarStatus(1);
                
            }
            else if(monstro.Nome == "Goblin")
            {
                player.Level += 2;
                player.Status.MelhorarStatus(2);
            }
            else
            {
                player.Level += 5;
                player.Status.MelhorarStatus(5);
            }
            System.Windows.Forms.MessageBox.Show("Parabéns!! Você subiu para o nivel " + player.Level);
            player.Dinheiro += monstro.DropDinheiro;
            System.Windows.Forms.MessageBox.Show("Monstro dropou " + monstro.DropDinheiro + "!");

        }

    }
}
