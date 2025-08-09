
using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable myCar = new Car();
            IMovable myBike = new Bicycle();

            myCar.Move();   // Output: Car is moving
            myBike.Move();  // Output: Bicycle is moving
        }
    }
}
