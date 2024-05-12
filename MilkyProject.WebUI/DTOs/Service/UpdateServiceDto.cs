namespace MilkyProject.WebUI.DTOs.Service
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        public string SmallImageUrl { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
