namespace BethanyPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> allPies {  get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie? GetPieById(int pieId);
    }
}
