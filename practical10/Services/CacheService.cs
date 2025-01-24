using Microsoft.Extensions.Caching.Memory;
using System;

namespace practical10.Services
{
    public class CacheService
    {
        private readonly IMemoryCache _memoryCache;

        public CacheService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public string GetCachedData()
        {
            string cacheKey = "CachedTime";
            if (!_memoryCache.TryGetValue(cacheKey, out string cachedTime))
            {
                cachedTime = DateTime.Now.ToString("F");
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromSeconds(30));
                _memoryCache.Set(cacheKey, cachedTime, cacheEntryOptions);
            }

            return cachedTime;
        }
    }
}
