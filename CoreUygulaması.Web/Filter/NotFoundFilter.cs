using CoreUygulaması.Web.ApiService;
using CoreUygulaması.Web.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Threading.Tasks;

namespace CoreUygulaması.Web.Filter
{
    public class NotFoundFilter : ActionFilterAttribute
    {
        private readonly CategoryApiService _categoryApiService;

        public NotFoundFilter(CategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = (int)context.ActionArguments.Values.FirstOrDefault();
            var category = await _categoryApiService.GetByIdAsync(id);

            if (category != null)
            {
                await next();
            }
            else
            {
                ErrorDTO errorDTO = new();
                errorDTO.Status = 404;
                errorDTO.Errors.Add($"id'si {id} olan kategori bulunamadı.");
                context.Result = new RedirectToActionResult("Error", "Home", errorDTO);
            }

        }
    }
}
