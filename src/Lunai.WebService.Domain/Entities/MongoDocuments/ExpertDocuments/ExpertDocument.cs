using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunai.WebService.Domain.Entities.MongoDocuments.ExpertDocuments
{
    public class  ExpertDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("nickname")]
        public string Nickname { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("date_birth")]
        public DateTime DateBirth { get; set; }

        [BsonElement("cpf_cnpj")]
        public string CpfCnpj { get; set; }

        [BsonElement("gender")]
        public string Gender { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("type")]
        public string Type { get; set; }

        [BsonElement("phone_number")]
        public string PhoneNumber { get; set; }

        [BsonElement("price_hour")]
        public decimal PriceHour { get; set; }

        [BsonElement("Adrress")]
        public Address AddressExpert { get; set; }

        [BsonElement("skills")]
        public List<string> Skills { get; set; }

        [BsonElement("jobs")]
        public JobsExperts Jobs { get; set; }
    }
}
