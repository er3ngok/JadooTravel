namespace JadooTravel.Dtos.CategoryDtos
{
    public class GetCategoryByIdDto
    {
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string IconURL { get; set; }
        public bool Status { get; set; }
    }
}
