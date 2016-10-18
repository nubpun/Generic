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
            var v1 = Processor.CreateEngine<Car>().For<Car2>().With<Car2>();
            var v2 = Processor.CreateEngine<Double>().For<Car2>().With<Car2>();
        }

        class Car
        {

        }

        class Car2
        {

        }
    }
}
