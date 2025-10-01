using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JadooTravel.Entities
{
    public class Category
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string IconURL { get; set; }
        public bool Status { get; set; }
    }
}
