using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();
            Console.WriteLine($"Брак составляет {class1.GetQuantityForProduct(1, 1, 40, 100, 50, 10)} еденицы продукта");
            Console.ReadKey();
        }
    }
}
