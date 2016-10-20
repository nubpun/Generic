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

        public object GetObj(Type type, Guid guid)
        {
            if (dict.ContainsKey(type))
            {
                if (dict[type].ContainsKey(guid))
                    return dict[type][guid];
            }
            return null;
            
        }

        public Dictionary<Guid, object> GetAll(Type type) 
        {
            if (dict.ContainsKey(type))
            {
                return dict[type];
            }
            return null;
        }
    }
}
