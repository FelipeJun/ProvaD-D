using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeD_prova_
{
    public abstract class Item
    {
        public string NomeItem { get; set; }
        public Status Status { get; set; }

        public Item(string nomeitem,Status status)
        {
            this.NomeItem = nomeitem;
            this.Status = status;
        }
    }
}
