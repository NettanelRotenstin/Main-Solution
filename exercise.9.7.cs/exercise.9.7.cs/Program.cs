using exercise._9._7.cs;
using System;
namespace exercise._9._7.cs
{
    enum Color { Blue, Red, Green }
    class Program
        {
    

        static public void Main(String[] args)
        {

            Car[] Cars = new Car[3];
            Cars[0] = new Car(Color.Blue);
            Cars[1] = new Car(Color.Green);
            Cars[2] = new Car(Color.Red);

            Cars[0].DisplayColor();
            Cars[1].DisplayColor();
            Cars[2].DisplayColor();

        }
    }

}