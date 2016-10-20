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
            test.Add<Car>();
            test.Add<Car>();
            test.Add<Car2>();
            test.Add<Car>();
            test.Add<Car2>();

            Car c1 = new Car();
            Car2 c2 = new Car2();

            var y = test.GetAll<Car>();
            Guid  k = new Guid();
            foreach (var v in y)
            {
                Console.WriteLine(v.Key + " " + v.Value);
                k = v.Key;
            }
            Console.WriteLine(test.GetObj<Car>(k));
            var y2 = test.GetAll<Car2>();
            Console.WriteLine();
            foreach (var v in y2)
            {
                Console.WriteLine(v.Key + " " + v.Value);
            }

        }

        class Car
        {
            static int count = 0;
            int id;
            public Car()
            {
                id = count;
                count++;
            }
            override
            public string ToString()
            {
                return "Car " + id;
            }
        }

        class Car2
        {
            static int count = 0;
            int id;
            public Car2()
            {
                id = count;
                count++;
            }
            override
            public string ToString()
            {
                return "Car2 " + id;
            }

        }
    }
}
