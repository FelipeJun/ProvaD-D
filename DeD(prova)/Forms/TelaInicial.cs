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
    public partial class TelaInicial : Form
    {
        public Jogador Player { get; set; }
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_nome.Text == "" || txt_nome.Text == " ")
                {
                    MessageBox.Show("O nome não pode ser vazio");
                    txt_nome.Text = "";
                }
                else
                {
                    this.Player = new Jogador(txt_nome.Text, 1, cmb_classe.SelectedItem.ToString());
                    this.Hide();
                    TelaStatus form = new TelaStatus(Player);
                    form.Show();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Occoreu um erro " + ex.Message);
            }
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            cmb_classe.SelectedIndex = 0;
        }
    }
}
