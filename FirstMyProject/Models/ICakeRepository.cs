namespace FirstMyProject.Models
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> AllCake {  get; }
        IEnumerable<Cake> CakeOfTheWeek { get; }
        Cake? GetCakeById(int cakeId);
    }
}
