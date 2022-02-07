using System.Collections.Generic;

namespace CoreUygulaması.Web.DTOs
{
    public class CategoryWithProductDTO : CategoryDTO
    {
        public ICollection<ProductDTO> Products { get; set; }
    }
}
