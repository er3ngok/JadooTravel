using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JadooTravel.Entities
{
    public class Destination
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string DestinationID { get; set; }
        public string CityCountry { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public string DayNight { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }

    }
}
