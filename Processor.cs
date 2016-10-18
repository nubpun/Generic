using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Processor<TEngine, TEntity, TLogger>
    {
    }

    class Processor<TEngine, TEntity>
    {

        public Processor<TEngine, TEntity, MyLogger> With<MyLogger>()
        {
            return new Processor<TEngine, TEntity, MyLogger>();
        }
    }

    class Processor<TEngine>
    {
        public Processor<TEngine, MyEntity> For<MyEntity>()
        {
            return new Processor<TEngine, MyEntity>();
        }
    }
    class Processor
    {
        public static Processor<TEngine> CreateEngine<TEngine>()
        {
            return new Processor<TEngine>();
        }
    }
}
