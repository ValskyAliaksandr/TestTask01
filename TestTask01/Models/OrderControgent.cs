namespace TestTask01.Models
{
    public class OrderControgent
    {
        public int Id { get; set; }
        public int? ControgentId { get; set; }
        public Controgent? Controgent { get; set; }
        public int? PolzovatelId { get; set; }
        public Polzovatel? Polzovatel { get; set; }
    }
}
