using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum State
{
    stop,
    run,
    dig,
    bring
}

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
        public State status { get; protected set; }

        public void Run()
        {
            status = State.run;
        }

        public void Stop()
        {
            status = State.stop;
        }
        
        public void ShowCurrentState()
        {
            Console.WriteLine(status);
        }
    }

    class Syoberu : Car
    {
        public void Dig()
        {
            status = State.dig;
        }

        public void Bring()
        {
            status = State.bring;
        }
    }
}
