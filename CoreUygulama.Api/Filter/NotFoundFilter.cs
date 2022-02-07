using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NetCoreUygulama.Api.DTOs;
using NetCoreUygulama.Core.Service;
using System.Linq;
using System.Threading.Tasks;

namespace CoreUygulama.Api.Filter
{
    public class NotFoundFilter : ActionFilterAttribute
    {
        private readonly IProductService _productService;

        public NotFoundFilter(IProductService productService)
        {
            _productService = productService;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = (int)context.ActionArguments.Values.FirstOrDefault();
            var product = await _productService.GetByIdAsync(id);

            if (product != null)
            {
                await next();
            }
            else
            {
                ErrorDTO errorDTO = new();
                errorDTO.Status = 404;
                errorDTO.Errors.Add($"id'si {id} olan ürün bulunamadı.");
                context.Result = new NotFoundObjectResult(errorDTO);
            }

        }
    }
}
