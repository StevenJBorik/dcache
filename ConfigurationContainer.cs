using Enyim.Caching.Configuration;
using Microsoft.Extensions.DependencyInjection; 
using System; 
using System.Collections.Generic; 

namespace dcache
{
    internal static class ConfigurationContainer {
        public static IServiceProvider Configure(); 
        var services =  new ServiceCollection(); 
        services.addLogging(); 
        services.AddEnyimMemcached(o => o.Servers = new List<Server> { new Server { Address = "localhost", Port = 11211 } });
        
         services.AddSingleton<ICacheProvider, CacheProvider>();
         services.AddSingleton<ICacheRepository, CacheRepository>();

        return services.BuildServiceProvider(); 
    }
}
