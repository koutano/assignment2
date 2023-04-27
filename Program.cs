using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Syoberu syoberu = new Syoberu();

            car.Stop();
            syoberu.Stop();
            car.Run();
            syoberu.Run();
            syoberu.Bring();

            Console.WriteLine(syoberu.status);
        }
    }

    class Car
    {
        public int status { get; protected set; }

        public void Run()
        {
            status = 0;
        }

        public void Stop()
        {
            status = 1;
        }
    }

    class Syoberu : Car
    {
        public void Dig()
        {
            status = 2;
        }

        public void Bring()
        {
            status = 3;
        }
    }
}
