using TestTask01.Models;
namespace TestTask01.Servisers
{
    public interface IControgentServises
    {
        public Controgent? Controgent { get; set; }
        public List<Controgent>? Controgents { get; set; }
        public Task ControgentIsBaseByUNP(string UNP);
        public Task GetStatusPortalByUNP(string UNP);

    }
}
