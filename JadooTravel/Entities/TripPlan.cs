using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JadooTravel.Entities
{
    public class TripPlan
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string TripPlanID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconURL { get; set; }

    }
}
