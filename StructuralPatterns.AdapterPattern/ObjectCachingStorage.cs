using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.AdapterPattern
{
    public class ObjectCachingStorage : ICacheStorage
    {
        public void Remove(string key)
        {
            MemoryCache.Default.Remove(key);
        }

        public void Store(string key, object data)
        {
            CacheItemPolicy policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = new DateTimeOffset(DateTime.Now.AddMinutes(1));
            MemoryCache.Default.Add(key, data, policy);
        }

        public T Retrieve<T>(string key)
        {
            return (T)MemoryCache.Default.Get(key);
        }
    }
}
