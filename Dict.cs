using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Dict
    {
        Dictionary<Type, Dictionary<Guid, object>> dict;

        public Dict()
        {
            dict = new Dictionary<Type, Dictionary<Guid, object>>();
        }

        public T Add<T>() where T : new()
        {
            T item = new T();
            Guid guid = Guid.NewGuid();
            if (!dict.ContainsKey(item.GetType()))
            {
                dict.Add(item.GetType(), new Dictionary<Guid, object>());
            }
            dict[item.GetType()].Add(guid, item);
            return item;
        }

        public T GetObj<T>(Guid guid) where T : new()
        {
            Type type = (new T()).GetType();
            if (dict.ContainsKey(type))
            {
                if (dict[type].ContainsKey(guid))
                    return (T)dict[type][guid];
            }
            return default(T);
            
        }

        public Dictionary<Guid, object> GetAll<T>() where T:new() 
        {
            Type type = (new T()).GetType();
            if (dict.ContainsKey(type))
            {
                return dict[type];
            }
            return null;
        }
    }
}
