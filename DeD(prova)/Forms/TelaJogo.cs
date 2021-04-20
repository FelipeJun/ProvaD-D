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
        Jogador Playerativo;
        public TelaJogo(Jogador Player)
        {
            InitializeComponent();
            Playerativo = Player;
        }
    }
}
