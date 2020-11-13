using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Shop
{
    public class Negozio
    {
        protected string OwnerName;
        protected string Name;

        public List<Prodotto> Products = new List<Prodotto>();

        //public List<ProdottoInOfferta> DiscountProducts = new List<ProdottoInOfferta>();

        public Negozio(string name, string owner)
        {
            this.Name = name;
            this.OwnerName = owner;
        }

        public Negozio(string name, string owner, List<Prodotto> products)
        {
            this.Name = name;
            this.OwnerName = owner;
            this.Products = products;
        }
    }
}
