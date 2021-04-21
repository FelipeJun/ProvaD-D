using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_.Itens
{
    class Cajado2 : Item
    {
        public Cajado2() : base("Cajado de Merlin", CriaStatus())
        {

        }
        public static Status CriaStatus()
        {
            return new Status(5, 10, 0, 0, 100, 100);
        }
    }
}
