using TestTask01.Models;
namespace TestTask01.Servisers
{
    public interface IPolzovatelServises
    {
        public Polzovatel? Polzovatel { get; set; }
        public List<Polzovatel>? Polzovatels { get; set; }
        public List<OrderControgent> OrderControgents { get; set; }
        public Task GetPolzovatelList();
        public Task GetPolzovatelByEmail(string email);
        public Task PolzovatelEdit(Polzovatel polzovatel);
        public Task GetControgentList(Polzovatel polzovatel);

    }
}
