
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        public static void Main(string[] args)
        {
           Rectangle rec = new Rectangle();
            rec.Width = 20;
            rec.Height = 20;
            System.Console.WriteLine(rec.CalculateArea());
            circle c = new circle();
            c.Radius = 30;
            System.Console.WriteLine(c.CalculatePeremeter());
        }
    }
}
