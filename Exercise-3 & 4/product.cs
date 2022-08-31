using System.Collections.Generic;
using Tutorial;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

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
        
        public static string con = @"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=products;Integrated Security=True";



        public void save()
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into product values ('"+this.inventorynumber +"','"+this.ProductName +"','"+this.price+"','"+this.Product_Discription+"',"+this.Amount+",'"+this.date+"')";
                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully");
            }

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
        public static List<product> GetAllproducts()
        {
            using (SqlConnection conect= new SqlConnection(con))
            {
                conect.Open();
                SqlCommand query = new SqlCommand("Select * from product", conect);
                var dataReder = query.ExecuteReader();

                products = getList<product>(dataReder);  
            }
            return products;
        }

        private static List<T> getList<T>(IDataReader reader)
        {
            List<T> list = new List<T>();
            while (reader.Read())
            {
                var type = typeof(T);
                T obje = (T)Activator.CreateInstance(type);

                foreach(var prop in type.GetProperties())
                {
                    var proType = prop.PropertyType;
                    prop.SetValue(obje, Convert.ChangeType(reader[prop.Name].ToString() ,proType));
                }
                list.Add(obje);
            }
            return list;
        }
    }
}