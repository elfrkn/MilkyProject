namespace MilkyProject.WebUI.DTOs.Product
{
    public class CreateProductDto
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public string? ImageUrl { get; set; }
        public bool Status { get; set; }
        public int? CategoryId { get; set; }

    }
}
