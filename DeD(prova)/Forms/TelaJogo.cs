using DeD_prova_.Classes;
using DeD_prova_.Monstros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeD_prova_.Forms
{
    public partial class TelaJogo : Form
    {
        Heroi Playerativo;

        Monstro monstroativo;

        public void MonstroAleatorio()
        {
            Random r = new Random();
            int monstrotela = r.Next(0, 3);
            if (monstrotela == 0)
            {
                monstroativo = new Slime();
            }
            else if (monstrotela == 1)
            {
                monstroativo = new Goblin();
            }
            else
            {
                monstroativo = new Dragao();
            }
            pcb_monstro.Image = Image.FromFile(monstroativo.ImagemMonstro);
            lbl_vidamonstro.Text = "Vida do monstro: " + monstroativo.Status.Vida.ToString();
        }

        public void VerificarTurno()
        {
            if (monstroativo.Status.Vida <= 0)
            {
                Heroi.SubirLevel(Playerativo, monstroativo);
                DialogResult DR = MessageBox.Show(monstroativo.Nome + " está morto! Deseja ir ao mercado ou continuar?", "Aviso", MessageBoxButtons.YesNo);
                if (DR == DialogResult.Yes)
                {
                    this.Hide();
                    Mercado form = new Mercado(Playerativo);
                    form.Show();

                }
                else
                {
                    MonstroAleatorio();
                    VerificarAtaques();
                    lbl_vidaheroi.Text = "Vida do herói: " + Playerativo.Status.Vida;
                    lbl_dinheiro.Text = "R$" + Playerativo.Dinheiro + ",00";
                }
            }

            if (Playerativo.Status.Vida <= 0)
            {
                MessageBox.Show("GAME OVER");
                Application.Exit();
            }
        }

        public void VerificarAtaques()
        {
            if(Playerativo.Inventario.Esquerda != null)
            {
                if (Playerativo.Inventario.Esquerda.NomeItem == "Espada")
                {
                    btn_ataque1.Text = "Atacar com espada";
                }
            }
            if (Playerativo.Inventario.Direita != null)
            {
                if (Playerativo.Inventario.Direita.NomeItem == "Escudo")
                {
                    btn_ataque2.Enabled = true;
                    btn_ataque2.Text = "avançar com escudo";
                }
                if (Playerativo.Inventario.Direita.NomeItem == "Cajado Boreal")
                {
                    btn_ataque1.Text = "Atirar bola de fogo";
                    btn_ataque2.Enabled = true;
                    btn_ataque2.Text = "Se curar (+50)";

                }
                if (Playerativo.Inventario.Direita.NomeItem == "Cajado de Merlin")
                {
                    btn_ataque1.Text = "Conjurar Meteoro";
                    btn_ataque2.Enabled = true;
                    btn_ataque2.Text = "Ficar Boladão";
                }

                if (Playerativo.Inventario.Direita.NomeItem == "Arco Boreal")
                {
                    btn_ataque1.Text = "Atirar flecha";
                }
                if (Playerativo.Inventario.Direita.NomeItem == "Arco Divino")
                {
                    btn_ataque2.Enabled = true;
                    btn_ataque2.Text = "Fazer chuva de flechas";
                }
            }
            
        }

        public void AtualizarLabels()
        {
            lbl_jogador.Text = "Jogador: " + Playerativo.Nome;
            lbl_level.Text = "Level: " + Playerativo.Level.ToString();
            lbl_classe.Text = "Classe: " + Playerativo.NomeClasse;
            lbl_forca.Text = "Força: " + Playerativo.Status.Forca.ToString();
            lbl_defesa.Text = "Defesa: " + Playerativo.Status.Defesa.ToString();
            lbl_agilidade.Text = "Agilidade: " + Playerativo.Status.Agilidade.ToString();
            lbl_sorte.Text = "Sorte: " + Playerativo.Status.Sorte.ToString();
            lbl_vida.Text = "Vida: " + Playerativo.Status.Vida.ToString();
            lbl_mana.Text = "Mana: " + Playerativo.Status.Mana.ToString();
            lbl_dinheiro.Text = "R$" + Playerativo.Dinheiro + ",00";
            lbl_vidaheroi.Text = "Vida do herói: " + Playerativo.Status.Vida;

            btn_ataque2.Enabled = false;
        }

        public TelaJogo(Heroi Player)
        {
            InitializeComponent();
            Playerativo = Player;
            AtualizarLabels();
            MonstroAleatorio();
            VerificarAtaques();
        }


        private void btn_ataque1_Click(object sender, EventArgs e)
        {
            Playerativo.Ataque(monstroativo);
            lbl_vidamonstro.Text = "Vida do monstro: " + monstroativo.Status.Vida.ToString();
            monstroativo.Ataque(Playerativo);
            lbl_vidaheroi.Text = "Vida do herói: " + Playerativo.Status.Vida;
            VerificarTurno();
            
        }

        private void btn_ataque2_Click(object sender, EventArgs e)
        {
            Playerativo.AtaqueEspecial(monstroativo);
            lbl_vidamonstro.Text = "Vida do monstro: " + monstroativo.Status.Vida.ToString();
            AtualizarLabels();
            VerificarTurno();
            btn_ataque2.Enabled = false;
        }

        private void TelaJogo_Load(object sender, EventArgs e)
        {

        }
    }
}
