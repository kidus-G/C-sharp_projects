using System.Collections.Generic;
using Tutorial;

namespace WindowsFormsApp1
{
    public class product
    {
        public static List<product> products = new List<product>();

        public string inventorynumber { get; set; }
        public string ProductName { get; set; }
        public string price { get; set; }
        public string Product_Discription { get; set; }
        public int Amount { get; set; }
        public string date { get; set; }
        public bool paypal { get; set; }
        public bool telebirr { get; set; }
        public bool Available { get; set; }
        public bool Not_Available { get; set; }

       


        public void save()
        { 
            products.Add(this);
        }
        public static void showAll()
        {
            foreach (product p in products)
            {
                System.Console.WriteLine(p.ProductName);
                System.Console.WriteLine(p.date);
                System.Console.WriteLine(p.inventorynumber);
                System.Console.WriteLine(p.Product_Discription);
                System.Console.WriteLine(p.Amount);

                System.Console.WriteLine(p.price);
                System.Console.WriteLine(p.paypal);
                System.Console.WriteLine(p.Available);
                System.Console.WriteLine(p.Not_Available);
            }
        }
        public static List<product> getAllproducts()
        {
            return products;
        }

    }
}