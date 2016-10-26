using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MongoImporter.Serializers
{
    public class DelimiterSerializer : ILineSerializer
    {
        private readonly char _delim;
        private readonly IEnumerable<string> _fieldNames;

        public DelimiterSerializer(char delim, IEnumerable<string> fieldNames)
        {
            _delim = delim;
            _fieldNames = fieldNames;
        }

        public BsonDocument SerializeLine(string line)
        {
            var doc = new BsonDocument();
            var parts = line.Split(_delim);

            for (var i = 0; i < _fieldNames.Count(); ++i)
            {
                doc.Set(_fieldNames.ElementAt(i), parts[i]);
            }
            return doc;
        }
    }
}
