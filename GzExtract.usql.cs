using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;

namespace usqlInvestigation
{
    public class USQLInvestigation
    {
        public static List<BsonDocument> LFWLogs = new List<BsonDocument>();

        public static string Append(string LFWLog)
        {
            string[] parameters = LFWLog.Split(' ');
            MongoClientSettings settings = new MongoClientSettings();
            
            MongoClient client = new MongoClient("<MONGO_URL>");
            IMongoDatabase db = client.GetDatabase("<DB_NAME>");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("<COLLECTION_NAME>");
            collection.InsertOne(new BsonDocument
                {
                  {"1", parameters[0]},
                  {"2", parameters[1]},
                  {"3", parameters[2]},
                  {"4", parameters[3]},
                  {"5", parameters[4]},
                  {"6", parameters[5]},
                  {"7", parameters[6]},
                });
            return "done";

        }
    }
}
