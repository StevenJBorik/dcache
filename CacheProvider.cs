using Enyim.Caching; 

namespace dcache
{
    internal interface ICacheProvider
    {
        T GetCache<T>(string key); 
    }
    internal class CacheProvider : ICacheProvider {
        private readOnly IMemcachedClient memcachedClient; 

        public CacheProvider(IMemcachedClient memcachedClient) {
            this.memcachedClient = memcachedClient; 
        }

        public T GetCache<T>(string key) {
            return memcachedClient.Get<T>(key); 
        }
    }
}