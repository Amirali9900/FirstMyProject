namespace FirstMyProject.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories {  get; }
    }
}
