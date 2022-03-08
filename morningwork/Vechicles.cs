using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace morningwork
{
    public abstract class Vechicle
    {
        private int wheels;

        public int Wheels { 
            get { return wheels; } 
            private set { wheels = value; }
        }

        public Vechicle(int wheels)
        {
            this.wheels = wheels;
        }

        public void MoveVechicle()
        {
            Console.WriteLine("the vechicle has been moved.");
        }

    }

    public class Car
    {

        private Tires _tires;
        private Engine _engine;

        public Tires Tires
        {
            get { return _tires; }
            set { _tires = value; }
        }
        public Engine Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }

        

        public Car(Tires tires, Engine engine)
        {
            _tires = tires;
            _engine = engine;
        }




     }

    public class Boat : IMove
    {
        public void MoveVechicle(int wheels)
        {
            Console.WriteLine($"The boat moves with {wheels}");
        }
    }

    public class Bike : IMove, IExhibit
    {
        public void MoveVechicle(int wheels)
        {
            Console.WriteLine($"The bike moved with it {wheels} wheels");
        }

        public string Show()
        {
            string a = "look at my sick wheels";
            Console.WriteLine(a);
            return a;
        }
    }
}
