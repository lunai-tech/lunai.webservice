using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Lunai.WebService.Domain.Entities.MongoDocuments.ExpertDocuments
{
    public class JobsExperts
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("job_id")]
        public string JobId { get; set; }

        [BsonElement("skills")]
        public List<string> Skills { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }

        [BsonElement("rating_job")]
        public int RatingJob { get; set; }
    }
}