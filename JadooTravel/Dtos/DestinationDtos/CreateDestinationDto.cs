namespace JadooTravel.Dtos.DestinationDtos
{
    public class CreateDestinationDto
    {
        public string CityCountry { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public decimal DayNight { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
    }
}
