using NetCoreUygulama.Api.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreUygulama.Api.DTOs
{
    public class CategoryWithProductDTO:CategoryDTO
    {
        public ICollection<ProductDTO> Products { get; set; } 
    }
}
