using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace app.Models
{
    public class ProductModel
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public decimal Price {get; set; }
    }
}