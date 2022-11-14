using System.ComponentModel.DataAnnotations.Schema;

namespace TestTask01.Models
{
    public class Controgent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string UNP { get; set; }
        public string? Status { get; set; }
        public List<OrderControgent>? OrderControgents { get; set; }
        [NotMapped]
        public bool isBase { get; set; }

    }
}
