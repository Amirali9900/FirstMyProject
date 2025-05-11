namespace FirstMyProject.Models
{
    public class Cake
    {
        public int CakeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? Information { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public decimal Price { get; set; }
        public bool IsCakeOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoriId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
