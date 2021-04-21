using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_.Itens
{
    class Arco2 : Item
    {
        public Arco2() : base("Arco Divino", CriaStatus())
        {

        }
        public static Status CriaStatus()
        {
            return new Status(10, 0, 20, 0, 0, 0);
        }
    }
}
