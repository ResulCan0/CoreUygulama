using System.Collections.Generic;

namespace CoreUygulaması.Web.DTOs
{
    public class ErrorDTO
    {
        public ErrorDTO()
        {
            Errors = new List<string>();
        }
        public List<string> Errors { get; set; }

        public int Status { get; set; }
    }
}
