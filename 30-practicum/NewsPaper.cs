using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_practicum
{
    class NewsPaper: PrintedProducts
    {
        private int numberOfSheets;
        private int circulation;
        private double costPerSheet;

        public NewsPaper(string title, int circulation, double costPerSheet, int numberOfSheets) : base(title)
        {
            Circulation = circulation;
            NumberOfSheets = numberOfSheets;
            CostPerSheet = costPerSheet;
        }

        public int NumberOfSheets 
        {
            get
            {
                return numberOfSheets;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("количество листов не может быть <= 0");
                }
                else
                {
                    numberOfSheets = value;
                }
            }
        }
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
        public double CostPerSheet
        {
            get
            {
                return costPerSheet;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("стоимость листа не может быть <= 0");
                }
                else
                {
                    costPerSheet = value;
                }
            }
        }
        public override double CostOfCirculation()
        {
            return NumberOfSheets * CostPerSheet * Circulation;
        }
        public override string ToString()
        {
            return $"Стоимость тиража: {CostOfCirculation()}. Количество листов: {NumberOfSheets}, стоимость одного листа: {CostPerSheet}, тираж: {Circulation}.";
        }
    }
}
