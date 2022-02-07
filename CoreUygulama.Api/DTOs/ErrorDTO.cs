using System;
using System.Collections.Generic;

namespace NetCoreUygulama.Api.DTOs
{
    public class ErrorDTO
    {
        public ErrorDTO()
        {
            Errors = new List<string>();
        }
        public List<String> Errors { get; set; }

        public int Status { get; set; }
    }
}
