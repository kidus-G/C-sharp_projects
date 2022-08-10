using System.Collections.Generic;
using Tutorial;

namespace WindowsFormsApp1
{
    public class product
    {
        public  List<product> products = new List<product>();

        public string inventorynumber { get; set; }
        public string id { get; set; }
        public string price { get; set; }
        public string ItemName { get; set; }
        public int count { get; set; }
        public string date { get; set; }
        public bool isavalable { get; set; }
        public bool Male { get; set; }
        public bool female { get; set; }

       


        public void save()
        { 
            products.Add(this);
        }
        public void showAll()
        {
            foreach (product p in products)
            {
                System.Console.WriteLine(p.ItemName);
                System.Console.WriteLine(p.price);
                System.Console.WriteLine(p.count);
                System.Console.WriteLine(p.date);
                System.Console.WriteLine(p.inventorynumber);
                System.Console.WriteLine(p.id);
                System.Console.WriteLine(this.isavalable);
                System.Console.WriteLine(this.Male);
                System.Console.WriteLine(this.female);


            }
        }

    }
}