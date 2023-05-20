using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingSystem
{
    public class CacheManager
    {
        private readonly IMemoryCache cache;

        public CacheManager()
        {
            cache = new MemoryCache(new MemoryCacheOptions());
        }

        public T GetOrSet<T>(string key, Func<T> getItemCallback, TimeSpan expirationTime)
        {
            if (!cache.TryGetValue(key, out T item))
            {
                item = getItemCallback();

                if (item != null)
                {
                    var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetAbsoluteExpiration(expirationTime);

                    cache.Set(key, item, cacheEntryOptions);
                }
            }

            return item;
        }
        
    }
}
