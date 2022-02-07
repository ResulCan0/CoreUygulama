using System.ComponentModel.DataAnnotations;

namespace CoreUygulaması.Web.DTOs
{
    public class PersonDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
    }
}
