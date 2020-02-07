using System;

namespace Exercise
{
    class Program
    {

        static void Main(string[] args)
        {
            car myObj = new car();
            Console.WriteLine("Color of car is" + " " + myObj.color);
            Console.WriteLine("Max speed of car is "+ " " + myObj.maxspeed);
        }
    }

    class car
    {
        public string color = "black";
        public int maxspeed = 200;
    }
}



