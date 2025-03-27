using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace _30_practicum
{
    class Magazine: PrintedProducts
    {
        private int circulation;
        private double price;

        public int Circulation
        {
            get
            {
                return circulation;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Тираж не может быть <= 0");
                }
                else
                {
                    circulation = value;
                }
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Стоимость не может быть <= 0");
                }
                else
                {
                    price = value;
                }
            }
        }

        public Magazine(string title, int circulation, double price) : base(title)
        {
            Circulation = circulation;
            Price = price;
        }
        public static Magazine Enter()
        {
            Console.Clear();
            Console.Write("Введите название журнала: ");
            string title = Console.ReadLine();
            Console.Write("Введите тираж: ");
            int circulation = int.Parse(Console.ReadLine());
            Console.Write("Введите стоимость журнала: ");
            double price = int.Parse(Console.ReadLine());
            return new Magazine(title, circulation, price);
        }

        public override double CostOfCirculation()
        {
            return Circulation * Price;
        }
        public override string ToString()
        {
            return $"Название: {Title}, стоимость тиража: {CostOfCirculation()}. Стоимость журнала: {Price}, тираж: {Circulation}.";
        }
    }   
}
