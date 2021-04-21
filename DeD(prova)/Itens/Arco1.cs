using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_.Itens
{
    class Arco1 : Item
    {
        public Arco1() : base("Arco Boreal", CriaStatus())
        {

        }
        public static Status CriaStatus()
        {
            return new Status(3, 0, 5, 0, 0, 0);
        }
    }
}
