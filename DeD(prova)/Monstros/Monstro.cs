using DeD_prova_.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_
{
    public abstract class Monstro
    {
        public string Nome { get; set; }
        public Status Status { get; set; }
        public string ImagemMonstro { get; set; }

        public Monstro(string nome, Status status, string imagem)
        {
            this.Nome = nome;
            this.Status = status;
            this.ImagemMonstro = imagem;
        }

        public abstract void Ataque(Heroi jogador);

        public float Defesa()
        {
            Random rand = new Random();
            return (this.Status.Defesa + this.Status.Agilidade) * (1 + (rand.Next(0, this.Status.Sorte) / 100));
        }

        public void RecebeAtaque(float valordano)
        {
            float Dano = this.Defesa() - valordano;
            if (Dano < 0)
            {
                this.Status.Vida += Dano;
            }
        }
    }
}
