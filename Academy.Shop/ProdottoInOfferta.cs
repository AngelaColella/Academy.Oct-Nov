using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Shop
{
    public class ProdottoInOfferta : Prodotto
    {
        public DateTime StartOffertDate { get; set; }

        public DateTime EndOffertDate { get; set; }

        public ProdottoInOfferta(int code, string description, double price, double discount, DateTime start, DateTime end)
            : base(code, description, price, discount)
        {
            this.StartOffertDate = start;
            this.EndOffertDate = end;
        }
    }
}
