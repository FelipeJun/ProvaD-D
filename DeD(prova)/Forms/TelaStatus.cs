using DeD_prova_.Classes;
using DeD_prova_.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeD_prova_
{
    public partial class TelaStatus : Form
    {
        Heroi Playerativo;
        public TelaStatus(Heroi Player)
        {
            InitializeComponent();
            Playerativo = Player;
            lbl_jogador.Text = "Jogador: "+Player.Nome;
            lbl_level.Text = "Level: "+Player.Level.ToString();
            lbl_classe.Text = Player.NomeClasse;

            nud_agilidade.Value = 50;
            nud_defesa.Value = 50;
            nud_forca.Value = 50;
            nud_mana.Value = 50;
            nud_sorte.Value = 50;
            nud_vida.Value = 50;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int forca = Convert.ToInt32(nud_forca.Value);
            int def = Convert.ToInt32(nud_defesa.Value);
            int agili = Convert.ToInt32(nud_agilidade.Value);
            int sorte = Convert.ToInt32(nud_sorte.Value);
            int vida =  Convert.ToInt32(nud_vida.Value);
            int mana = Convert.ToInt32(nud_mana.Value);
            int ValorPontosTotais = forca + def + agili + sorte + vida + mana;

            if(ValorPontosTotais > 300)
            {
                MessageBox.Show("O valor distribuído passou de 300 pontos");
            }
            else if(ValorPontosTotais < 300)
            {
                MessageBox.Show("Falta " + (300 - ValorPontosTotais) + " para os 300 pontos");
            }
            else
            {
                Playerativo.ReceberStatus(forca , def , agili , sorte , vida , mana);
                this.Hide();
                TelaJogo form = new TelaJogo(Playerativo);
                form.Show();
            }
        }
    }
}
