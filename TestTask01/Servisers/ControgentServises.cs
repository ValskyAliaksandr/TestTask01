using TestTask01.Models;

namespace TestTask01.Servisers
{
    public class ControgentServises : IControgentServises
    {
        public Controgent? Controgent { get; set; }
        public List<Controgent> Controgents { get; set; }

        public Task ControgentIsBase(Controgent controgent)
        {
            return Task.CompletedTask;
        }

        public Task GetStatusPortal(Controgent controgent)
        {
            return Task.CompletedTask;
        }
    }
}
