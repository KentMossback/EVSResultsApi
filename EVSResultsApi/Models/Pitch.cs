using System.ComponentModel.DataAnnotations;

namespace EVSResultsApi.Models
{
    public class Pitch
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
