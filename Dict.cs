using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Dict
    {
        Dictionary<Guid, object> dict;
        Dictionary<Type, List<Guid>> dictCollection;

        public Dict()
        {
            dict = new Dictionary<Guid, object>();
            dictCollection = new Dictionary<Type, List<Guid>>();
        }

        public T Add<T>(T item)
        {
            Guid guid = Guid.NewGuid();
            dict[guid] = item;

            if (!dictCollection.ContainsKey(item.GetType()))
            {
                dictCollection.Add(item.GetType(), new List<Guid>());
            }

            dictCollection[item.GetType()].Add(guid);
            return item;
        }

        public object GetObjByGuid(Guid guid)
        {
            return dict[guid];
        }

        public List<Tuple<Guid, object>> GetAll(Type type) 
        {
            List<Tuple<Guid, object>> list = new List<Tuple<Guid, object>>();
            if (dictCollection.ContainsKey(type))
            {
                foreach (var v in dictCollection[type])
                {
                    Tuple<Guid, object> tp = new Tuple<Guid, object>(v, dict[v]);
                    list.Add(tp);
                }
            }
            return list;
        }
    }
}
