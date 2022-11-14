namespace TestTask01.Models
{
    public class Polzovatel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; }
        public List<OrderControgent>? OrderControgents { get; set;}
    }
}
