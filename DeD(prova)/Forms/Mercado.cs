using DeD_prova_.Classes;
using DeD_prova_.Itens;
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
    public partial class Mercado : Form
    {

        Heroi Playerativo;
        public Mercado(Heroi Player)
        {
            InitializeComponent();
            Playerativo = Player;
            lbl_jogador.Text = "Jogador: " + Playerativo.Nome;
            lbl_level.Text = "Level: " + Playerativo.Level.ToString();
            lbl_classe.Text = "Classe: " + Playerativo.NomeClasse;
            lbl_vida.Text = "Vida: " + Playerativo.Status.Vida;
            VerificarClasse(Playerativo.NomeClasse);
        }

        public void VerificarClasse(string classe)
        {
            if(classe == "Guerreiro")
            {
                btn_escudo.Enabled = true;
                btn_espada.Enabled = true;
            }
            else if(classe == "Mago")
            {
                btn_cajado1.Enabled = true;
                btn_cajado2.Enabled = true;
            }
            else
            {
                btn_arco1.Enabled = true;
                btn_arco2.Enabled = true;
            }
        }

        private void btn_poção_Click(object sender, EventArgs e)
        {
            Playerativo.Status.Vida += 50;
            lbl_vida.Text = "Vida: " + Playerativo.Status.Vida;
            btn_poção.Enabled = false;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            TelaJogo form = new TelaJogo(Playerativo);
            this.Close();
            form.Show();
        }

        private void btn_espada_Click(object sender, EventArgs e)
        {
            Espada espada = new Espada();
            Playerativo.Inventario.esquerda = espada;

            Status.AdicionarStatusItens(Playerativo, espada);

        }
    }
}
