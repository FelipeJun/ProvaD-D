using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_.Itens
{
    class Escudo : Item
    {
        public Escudo() : base("Escudo", CriaStatus())
        {

        }
        public static Status CriaStatus()
        {
            return new Status(0, 10, 0, 0, 0, 0);
        }
    }
}
