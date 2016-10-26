using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoImporter.Serializers;

namespace MongoImporter
{
    public class Importer
    {
        private readonly MongoClient _client;
        private IMongoDatabase _db;
        private IMongoCollection<BsonDocument> _collection;
        public string InputFile { get; set; }
        public int BatchSize { get; set; } = 100;
        public ILineSerializer Serializer { get; set; };

        public Importer(MongoClient client)
        {
            _client = client;
        }

        public void SetDatabase(string name)
        {
            _db = _client.GetDatabase(name);
        }

        public void SetCollection(string name)
        {
            _collection = _db.GetCollection<BsonDocument>(name);
        }

        public async void ReadFromFile()
        {
            using (var sr = new StreamReader(InputFile))
            {
                Task insertionTask = null;
                while (sr.Peek() >= 0)
                {
                    var documents = new List<BsonDocument>();
                    var line = await sr.ReadLineAsync();
                    documents.Add(Serializer.SerializeLine(line));
                    if (insertionTask != null) await insertionTask;
                    insertionTask = _collection.InsertManyAsync(documents);
                }
            }
        }
    }
}
