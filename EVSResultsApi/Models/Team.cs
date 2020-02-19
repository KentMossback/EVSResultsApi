using System.ComponentModel.DataAnnotations;

namespace EVSResultsApi.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string ImageUrl { get; set; }
    }
}
