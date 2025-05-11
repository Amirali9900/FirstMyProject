namespace FirstMyProject.Models
{
    public class Cake
    {
        public int CakeID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ShortDiscription { get; set; }
        public string? LongDiscription { get; set; }
        public string? Information { get; set; }
        public string? IamgeUrl { get; set; }
        public string? IamgeThumbnailUrl { get; set; }
        public decimal Price { get; set; }
        public bool IsCakeOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoriId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
