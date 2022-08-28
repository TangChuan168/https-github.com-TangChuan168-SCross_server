using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCserver.Mongo
{
    public static class Extension
    {
        public static void AddMongoDB(this IServiceCollection services,IConfiguration Congiguration)
        {
            services.Configure<MongoOption>(Congiguration.GetSection("Mongo"));
            services.AddSingleton<MongoClient>(x=> {
                var option = x.GetService<IOptions<MongoOption>>();

                return new MongoClient(option.Value.ConnectionString);
            });

            services.AddScoped<IMongoDatabase>(c=> {
                var options = c.GetService<IOptions<MongoOption>>();
                var client = c.GetService<MongoClient>();

                return client.GetDatabase(options.Value.Database);

            });
        }
    }
}
