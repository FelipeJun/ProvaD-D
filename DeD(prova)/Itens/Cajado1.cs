using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_.Itens
{
    class Cajado1 : Item
    {
        public Cajado1() : base("Cajado Boreal", CriaStatus())
        {

        }
        public static Status CriaStatus()
        {
            return new Status(2, 0, 0, 0, 50, 20);
        }
    }
}
