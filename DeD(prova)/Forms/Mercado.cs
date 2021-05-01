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
            lbl_dinheiro.Text = "R$" + Playerativo.Dinheiro + ",00";
            lbl_mana.Text = "Mana: " + Playerativo.Status.Mana;
            VerificarClasse(Playerativo.NomeClasse);
            //teste
        }

        public void VerificarClasse(string classe)
        {
            if(classe == "Guerreiro")
            {
                if (Playerativo.Inventario.Esquerda == null)
                {
                    btn_espada.Enabled = true;
                }
                if (Playerativo.Inventario.Direita == null)
                {
                    btn_escudo.Enabled = true;
                }

            }
            else if(classe == "Mago")
            {
                if (Playerativo.Inventario.Direita == null)
                {
                    btn_cajado1.Enabled = true;
                }
                else
                {
                    btn_cajado2.Enabled = true;
                }

            }
            else
            {
                if (Playerativo.Inventario.Direita == null) 
                {
                    btn_arco1.Enabled = true;
                }
                else
                {
                    btn_arco2.Enabled = true;
                }
               
            }
        }

        private void btn_poção_Click(object sender, EventArgs e)
        {
            if(Playerativo.Dinheiro < 30)
            {
                MessageBox.Show("Sem dinheiro");
            }
            else
            {
                Playerativo.Status.Vida += 50;
                lbl_vida.Text = "Vida: " + Playerativo.Status.Vida;
                Playerativo.Dinheiro -= 30;
                lbl_dinheiro.Text = "R$" + Playerativo.Dinheiro + ",00";
                btn_poção.Enabled = false;
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            TelaJogo form = new TelaJogo(Playerativo);
            this.Close();
            form.Show();
        }

        private void btn_espada_Click(object sender, EventArgs e)
        {
                if (Playerativo.Dinheiro < 50)
            {
                MessageBox.Show("Sem dinheiro");
            }
            else
            {
                Espada espada = new Espada();
                Playerativo.Inventario.Esquerda = espada;
                Status.AdicionarStatusItens(Playerativo, espada);
                Playerativo.Dinheiro -= 50;
                lbl_dinheiro.Text = "R$" + Playerativo.Dinheiro + ",00";
                btn_espada.Enabled = false;
            }

        }

        private void btn_escudo_Click(object sender, EventArgs e)
        {
            if(Playerativo.Dinheiro < 50)
            {
                MessageBox.Show("Sem dinheiro");
            }
            else
            {
                Escudo escudo = new Escudo();
                Playerativo.Inventario.Direita = escudo;
                Status.AdicionarStatusItens(Playerativo, escudo);
                Playerativo.Dinheiro -= 50;
                lbl_dinheiro.Text = "R$" + Playerativo.Dinheiro + ",00";
                btn_escudo.Enabled = false;
            }

        }

        private void btn_arco1_Click(object sender, EventArgs e)
        {
            if (Playerativo.Dinheiro < 25)
            {
                MessageBox.Show("Sem dinheiro");
            }
            else
            {
                Arco1 arco1 = new Arco1();
                Playerativo.Inventario.Direita = arco1;
                Status.AdicionarStatusItens(Playerativo, arco1);
                Playerativo.Dinheiro -= 25;
                lbl_dinheiro.Text = "R$" + Playerativo.Dinheiro + ",00";
                btn_arco1.Enabled = false;
            }

        }

        private void btn_arco2_Click(object sender, EventArgs e)
        {
            if (Playerativo.Dinheiro < 200)
            {
                MessageBox.Show("Sem dinheiro");
            }
            else
            {
                Arco2 arco2 = new Arco2();
                Playerativo.Inventario.Direita = arco2;
                Status.AdicionarStatusItens(Playerativo, arco2);
                Playerativo.Dinheiro -= 200;
                lbl_dinheiro.Text = "R$" + Playerativo.Dinheiro + ",00";
                btn_arco2.Enabled = true;
            }

        }

        private void btn_cajado1_Click(object sender, EventArgs e)
        {
            if (Playerativo.Dinheiro < 50)
            {
                MessageBox.Show("Sem dinheiro");
            }
            else
            {
                Cajado1 cajado1 = new Cajado1();
                Playerativo.Inventario.Direita = cajado1;
                Status.AdicionarStatusItens(Playerativo, cajado1);
                Playerativo.Dinheiro -= 50;
                lbl_dinheiro.Text = "R$" + Playerativo.Dinheiro + ",00";
                btn_cajado1.Enabled = false;
            }
            
        }

        private void btn_cajado2_Click(object sender, EventArgs e)
        {
            if (Playerativo.Dinheiro < 300)
            {
                MessageBox.Show("Sem dinheiro");
            }
            else
            {
                Cajado2 cajado2 = new Cajado2();
                Playerativo.Inventario.Direita = cajado2;
                Status.AdicionarStatusItens(Playerativo, cajado2);
                Playerativo.Dinheiro -= 300;
                lbl_dinheiro.Text = "R$" + Playerativo.Dinheiro + ",00";
                btn_cajado2.Enabled = false;
            }
           
        }

        private void btn_pocaomana_Click(object sender, EventArgs e)
        {
            if (Playerativo.Dinheiro < 30)
            {
                MessageBox.Show("Sem dinheiro");
            }
            else
            {
                Playerativo.Status.Mana += 50;
                lbl_mana.Text = "Mana: " + Playerativo.Status.Mana;
                Playerativo.Dinheiro -= 30;
                lbl_dinheiro.Text = "R$" + Playerativo.Dinheiro + ",00";
                btn_pocaomana.Enabled = false;
            }
        }
    }
}
