namespace FirstMyProject.Models
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> AllCake {  get; }
        IEnumerable<Cake> CakesOfTheWeek { get; }
        Cake? GetCakeById(int cakeId);
    }
}
