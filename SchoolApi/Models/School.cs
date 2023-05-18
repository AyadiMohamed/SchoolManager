using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Sections { get; set; } = null!;
        public string Director { get; set; } = null!;

        [Range(1, 5, ErrorMessage = "valeur entre 1 et 5")]
        public double  Rating { get; set; }
        [Url(ErrorMessage ="Url non vide")]
        public string ? WebSite  { get; set; }
    }
}
