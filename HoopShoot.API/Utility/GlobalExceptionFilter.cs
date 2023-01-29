using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Data.Common;
using System.Data.Entity.Core;

namespace HoopShoot.API.Utility
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        private const string ErrorMessage = "Something went wrong.";
        public void OnException(ExceptionContext context)
        {
            if (!context.ExceptionHandled)
            {
                var exception = context.Exception;
                var statusCode = 0;

                switch (true)
                {
                    case bool _ when exception is EntityException:
                    case bool _ when exception is DbException:
                        statusCode = StatusCodes.Status500InternalServerError;
                        break;
                }

                context.Result = new ObjectResult(ErrorMessage) { StatusCode = statusCode };
            }
        }
    }
}
