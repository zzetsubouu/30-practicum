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

        public override double CostOfCirculation()
        {
            return Circulation * Price;
        }
        public override string ToString()
        {
            return $"Стоимость тиража: {CostOfCirculation()}. Стоимость журнала: {Price}, тираж: {Circulation}.";
        }
    }   
}
