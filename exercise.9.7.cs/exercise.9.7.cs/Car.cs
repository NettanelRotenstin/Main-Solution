using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exercise._9._7.cs
{
    internal class Car
    {
        private Color carColor;

        public Car(Color color )
        {
            carColor = color;
        }
        public void DisplayColor()
        {
            Console.WriteLine(carColor.ToString());
        }
    }
}
