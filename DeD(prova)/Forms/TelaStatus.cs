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
        Jogador Playerativo;
        public TelaStatus(Jogador Player)
        {
            InitializeComponent();
            Playerativo = Player;
            lbl_jogador.Text = "Jogador: "+Player.Nome;
            lbl_level.Text = "Level: "+Player.Level.ToString();
            lbl_classe.Text = "Classe: "+Player.Classe;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int ValorPontosTotais = Convert.ToInt32(nud_agilidade.Value) + Convert.ToInt32(nud_defesa.Value) + Convert.ToInt32(nud_forca.Value) + Convert.ToInt32(nud_mana.Value) + Convert.ToInt32(nud_sorte.Value) + Convert.ToInt32(nud_vida.Value);
            if(ValorPontosTotais > 300)
            {
                MessageBox.Show("O valor distribuído passou de 300 pontos");
            }
            else
            {

                this.Hide();
                TelaJogo form = new TelaJogo(Playerativo);
                form.Show();
            }
        }
    }
}
