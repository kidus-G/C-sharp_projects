using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class product
    {
        public string inventorynumber { get; set; }
        public string id { get; set; }
        public string price { get; set; }
        public string ItemName { get; set; }
        public int count { get; set; }
        public string date { get; set; }

       static List<product> products = new List<product>();

        

        public void save()
        {
            products.Add(this);
        }
        public void showAll()
        {
            for(int i = 0; i < products.Count; i++)
            {
            }
        }

    }
}