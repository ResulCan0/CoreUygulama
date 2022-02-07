using NetCoreUygulama.Api.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace CoreUygulama.Web.Filter
{
    public class ValidationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                ErrorDTO errorDTO = new();

                errorDTO.Status = 400;

                IEnumerable<ModelError> modelError = context.ModelState.Values.SelectMany(v => v.Errors);

                modelError.ToList().ForEach(x =>
                {
                    errorDTO.Errors.Add(x.ErrorMessage);
                });

                context.Result = new BadRequestObjectResult(errorDTO);
            }
        }
    }
}
