using System.ComponentModel.DataAnnotations;

namespace CoreUygulaması.Web.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Alanı Boş Bırakılamaz.")]
        public string Name { get; set; }
    }
}
