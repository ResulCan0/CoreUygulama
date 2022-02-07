using System.ComponentModel.DataAnnotations;

namespace NetCoreUygulama.Api.DTOs
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
