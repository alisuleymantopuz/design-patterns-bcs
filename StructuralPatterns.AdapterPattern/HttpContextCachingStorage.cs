using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StructuralPatterns.AdapterPattern
{
    public class HttpContextCachingStorage : ICacheStorage
    {
        public void Remove(string key)
        {
            HttpContext.Current.Cache.Remove(key);
        }

        public void Store(string key, object data)
        {
            HttpContext.Current.Cache.Insert(key, data);
        }

        public T Retrieve<T>(string key)
        {
            T items = (T)HttpContext.Current.Cache.Get(key);
            if (items == null)
            {
                items = default(T);
            }
            return items;
        }
    }
}
