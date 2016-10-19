using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dict test = new Dict();
            test.Add(new Car2());
            test.Add(new Car());
            test.Add(new Car());
            test.Add(new Car());
            test.Add(new Car());
            test.Add(new Car2());
            Car2 c2 = new Car2();
            Car c1 = new Car();
            foreach (var v in test.GetAll(c1.GetType()))
            {
                Console.WriteLine(v.Item1 + " " + v.Item2);
            }
        }

        class Car
        {
            static int count = 0;
            public Car()
            {
                count++;
            }
            override
            public string ToString()
            {
                return "Car " + count;
            }
        }

        class Car2
        {
            static int count = 0;
            public Car2()
            {
                count++;
            }
            override
            public string ToString()
            {
                return "Car2 " + count;
            }

        }
    }
}
