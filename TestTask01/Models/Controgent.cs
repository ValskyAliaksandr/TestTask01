using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TestTask01.Models
{
    public class Controgent
    {
        public int Id { get; set; }
        [JsonPropertyName("VNAIMP")]
        public string? Name { get; set; }
        public string UNP { get; set; }
        [JsonPropertyName("VKODS")]
        public string? Status { get; set; }
        public List<OrderControgent>? OrderControgents { get; set; }
        [NotMapped]
        public bool isBase { get; set; }

    }
}
