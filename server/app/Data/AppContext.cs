using System;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using app.Models;

namespace app.Data
{
    public class AppContext
    {
        private readonly IMongoDatabase _database;

        public AppContext(IOptions<Settings> settings){
            try
            {
                var client = new MongoClient(settings.Value.ConnectionString);
                if(client != null)
                {
                    _database = client.GetDatabase(settings.Value.Database);
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception("Can not access to MongoDb server", ex);
            }
        }

        public IMongoCollection<ProductModel> Products => _database.GetCollection<ProductModel>("products");
    }
}