using DeD_prova_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_
{
    public class Status
    {
        public float Forca { get; set; }
        public float Defesa { get; set; }
        public float Agilidade { get; set; }
        public int Sorte { get; set; }
        public float Vida { get; set; }
        public float Mana { get; set; }

        public Status(int forca, int def, int agi, int sorte, int vida, int mana)
        {
            this.Forca = forca;
            this.Defesa = def;
            this.Agilidade = agi;
            this.Sorte = sorte;
            this.Vida = vida;
            this.Mana = mana;
        }

        public void MelhorarStatus(int niveluppado)
        {
            this.Forca += niveluppado;
            this.Defesa += niveluppado;
            this.Agilidade += niveluppado;
            this.Sorte += niveluppado;
            this.Vida += niveluppado;
            this.Mana += niveluppado;
        }

        public static void AdicionarStatusItens(Heroi player, Item item)
        {
            player.Status.Forca += item.Status.Forca;
            player.Status.Defesa += item.Status.Defesa;
            player.Status.Agilidade += item.Status.Agilidade;
            player.Status.Sorte += item.Status.Sorte;
            player.Status.Vida += item.Status.Vida;
            player.Status.Mana += item.Status.Mana;
        }
    }
}
