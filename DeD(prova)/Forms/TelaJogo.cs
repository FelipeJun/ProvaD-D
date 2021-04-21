﻿using DeD_prova_.Classes;
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

        public TelaJogo(Heroi Player)
        {
            InitializeComponent();
            Playerativo = Player;
            lbl_jogador.Text = "Jogador: " + Player.Nome;
            lbl_level.Text = "Level: " + Player.Level.ToString();
            lbl_classe.Text = "Classe: " + Player.NomeClasse;

            lbl_forca.Text = "Força: " + Playerativo.Status.Forca.ToString();
            lbl_defesa.Text = "Defesa: " + Playerativo.Status.Defesa.ToString();
            lbl_agilidade.Text = "Agilidade: " + Playerativo.Status.Agilidade.ToString();
            lbl_sorte.Text = "Sorte: " + Playerativo.Status.Sorte.ToString();
            lbl_vida.Text = "Vida: " + Playerativo.Status.Vida.ToString();
            lbl_mana.Text = "Mana: " + Playerativo.Status.Mana.ToString();


            lbl_vidaheroi.Text = "Vida do herói: " + Playerativo.Status.Vida;
            MonstroAleatorio();
        }

        private void btn_ataque1_Click(object sender, EventArgs e)
        {
            Playerativo.Ataque(monstroativo);
            lbl_vidamonstro.Text = "Vida do monstro: " + monstroativo.Status.Vida.ToString();
            monstroativo.Ataque(Playerativo);
            lbl_vidaheroi.Text = "Vida do herói: " + Playerativo.Status.Vida;
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
                    lbl_vidaheroi.Text = "Vida do herói: " + Playerativo.Status.Vida;
                }
            }

            if (Playerativo.Status.Vida <= 0)
            {
                MessageBox.Show("GAME OVER");
                Application.Exit();
            }
        }
    }
}
