using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Assignment_3
{
    public class EkseptioAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context) 
        {
            JsonResult error = new JsonResult(context.Exception.Message);
            error.StatusCode = StatusCodes.Status422UnprocessableEntity;

            context.ExceptionHandled = true;
            context.Result = error;
        }
    }
}