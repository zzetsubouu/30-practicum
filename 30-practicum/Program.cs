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
            var magazine1 = new Magazine("lololol", 1000, 10);
            var newsPaper1 = new NewsPaper("bebebe", 10000, 0.1, 30);
            Console.WriteLine(magazine1.ToString());
            Console.WriteLine(newsPaper1.ToString());
            Console.ReadKey();
        }
    }
}
