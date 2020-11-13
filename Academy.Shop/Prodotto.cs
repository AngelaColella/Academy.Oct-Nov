using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Shop
{
    public class Prodotto
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        public Prodotto(int code, string description, double price, double discount)
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;
            this.Discount = discount;
        }

        public Prodotto(string description, double price, double discount)
        {
            this.Code = -1;

        }

        public Prodotto(int code, string description)
        {
            this.Price = 0;
            this.Discount = 0;
        }

        public Prodotto(string description)
        {

        }
    }
}
