using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_.Itens
{
    class Espada : Item
    {
        public Espada() : base("Espada",CriaStatus())
        {

        }
        public static Status CriaStatus()
        {
            return new Status(10,0,0,0,0,0);
        }
    }
}
