using DeD_prova_.Classes;
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
        public Heroi Playerativo { get; set; }
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_nome.Text == "")
                {
                    MessageBox.Show("O nome não pode ser vazio");
                    txt_nome.Text = "";
                }
                else
                {
                    if(cmb_classe.SelectedItem.ToString() == "Guerreiro") 
                    {
                        this.Playerativo = new Guerreiro(txt_nome.Text, 1, "Guerreiro");
                    }
                    else if (cmb_classe.SelectedItem.ToString() == "Mago")
                    {
                        this.Playerativo = new Mago(txt_nome.Text, 1, "Mago");
                    }
                    else
                    {
                        this.Playerativo = new Arqueiro(txt_nome.Text, 1, "Arqueiro");
                    }
                    this.Hide();
                    TelaStatus form = new TelaStatus(Playerativo);
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
