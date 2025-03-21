using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_practicum
{
    abstract class PrintedProducts
    {
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Название не может быть пустым");
                }
            }
        }
        public PrintedProducts()
        {

        }
        public PrintedProducts(string title)
        {
            Title = title;
        }
        public abstract double CostOfCirculation();
    }
}
