using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            List <PrintedProducts> printedProducts= new List<PrintedProducts>();
            bool flag = true;
            while (flag)
            {
                Console.Write("введите название печатной продукции (n или m, l для выхода): ");
                string mark = Console.ReadLine();
                switch (mark.ToLower())
                {
                    case "m":
                    {
                        printedProducts.Add(Magazine.Enter()); break;
                    }
                    case "n":
                    {
                        printedProducts.Add(NewsPaper.Enter()); break;
                        }
                    case "l":
                    {
                        Console.WriteLine("Завершение работы...");
                        flag = false;
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Нет такой печатной продукции."); break;
                    }
                }
            }
            foreach (var product in printedProducts)
            {
                Console.WriteLine(product.ToString());
            }
            Console.ReadKey();
        }
    }
}
