

using MongoDB.Bson.Serialization.Attributes;

namespace Lunai.WebService.Domain.Entities.MongoDocuments
{
    public class Address
    {
        [BsonElement("cep")]
        public string Cep { get; set; }

        [BsonElement("address")]
        public string AddressValue { get; set; }

        [BsonElement("number")]
        public string Number { get; set; }

        [BsonElement("district")]
        public string District { get; set; }

        [BsonElement("complement")]
        public string Complement { get; set; }

        [BsonElement("city")]
        public string City { get; set; }

        [BsonElement("state")]
        public string State { get; set; }
    }
}
