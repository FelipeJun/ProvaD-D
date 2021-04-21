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
    }
}
