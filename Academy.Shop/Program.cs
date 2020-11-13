using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateProducts();
            CreateOffertProducts();
        }

        private static void CreateProducts()
        {

            Console.WriteLine("Choose a name for the shop:");
            string name = System.Console.ReadLine();
            Console.WriteLine("Choose a name for the owner:");
            string owner = System.Console.ReadLine();

            List<Prodotto> products_list = new List<Prodotto>();

            double discount = 0;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Insert a code for the product {0}:", i);
                int code = Convert.ToInt32(System.Console.ReadLine());
                Console.WriteLine("Insert a description for the product {0}:", i);
                string description = System.Console.ReadLine();
                Console.WriteLine("Insert a price for the product {0}:", i);
                double price = Convert.ToDouble(System.Console.ReadLine());

                //Console.WriteLine("Insert a discount for the product {0}:", i);
                //double discount = Convert.ToDouble(System.Console.ReadLine());

                Prodotto product = new Prodotto(code, description, price, discount);

                products_list.Add(product);
            }

            Negozio shop = new Negozio(name, owner, products_list);

            Console.Clear();

            foreach (Prodotto item in products_list)
            {
                Console.WriteLine("Product code:" + item.Code + "\tDescription:" + item.Description + "\tPrice:" + item.Price + "$" + "\tDiscount:" + item.Discount + "%");
            }

        }
        private static void CreateOffertProducts()
        {
            List<ProdottoInOfferta> TodayDiscounts_list = new List<ProdottoInOfferta>();

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Insert a code for the discounted product {0}:", i);
                int code = Convert.ToInt32(System.Console.ReadLine());
                Console.WriteLine("Insert a description for the discounted product {0}:", i);
                string description = System.Console.ReadLine();
                Console.WriteLine("Insert a price for the discounted product {0}:", i);
                double price = Convert.ToDouble(System.Console.ReadLine());
                Console.WriteLine("Insert a discount for the discounted product {0}:", i);
                double discount = Convert.ToDouble(System.Console.ReadLine());


                DateTime thisday = DateTime.Today;
                DateTime startDiscountPeriod = thisday.AddMonths(1);
                DateTime endDiscountPeriod = thisday.AddMonths(2);

                DateTime start_date = DateHelper.GetRandomDate(thisday, startDiscountPeriod);
                DateTime end_date = DateHelper.GetRandomDate(startDiscountPeriod, endDiscountPeriod);

                ProdottoInOfferta discounted_product = new ProdottoInOfferta(code, description, price, discount, start_date, end_date);

                if (discounted_product.StartOffertDate.Date == thisday.Date)
                {
                    TodayDiscounts_list.Add(discounted_product);
                    break;
                }
            }

            Console.Clear();

            if (TodayDiscounts_list.Count == 0)
            {
                Console.WriteLine("There aren't discounted products today");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Today's offertes \t");
                foreach (ProdottoInOfferta item in TodayDiscounts_list)
                {
                    Console.WriteLine("Product code:" + item.Code + "\tDescription:" + item.Description + "\tPrice:" + item.Price + "$" + "\tDiscount:" + item.Discount + "%" + "\tThe offert starts on:" + item.StartOffertDate.Date + "\tThe offert ends on:" + item.EndOffertDate.Date);

                }
            }
        }
    }
}
