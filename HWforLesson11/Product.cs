using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson11
{
    abstract class Product
    {
        public readonly string Name;

        /// <summary>
        /// Калорийность на 100 грамм
        /// </summary>
        public readonly int Calorie;
        /// <summary>
        /// Вес в граммах
        /// </summary>
        public double Weight { get; set; }
        public int Quantity { get; set; }
        public int Energy => (int)(Weight / 100 * Calorie);

        public Product(string name, int calorie)
        {
            this.Name = name;
            this.Calorie = calorie;
        }

        public override string ToString()
        {
            return $"Название: {Name}, калорийность на 100 грамм: {Calorie}";
        }


    }
}
