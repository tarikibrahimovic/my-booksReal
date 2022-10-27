using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using my_booksReal.Data.ViewModel;
using System.Net;
using System.Runtime.CompilerServices;

namespace my_booksReal.Exceptions
{
    //public class ExceptionMiddleWareExtension
    //{

    //    public static void ConfigureBuildExceptionHandler(this IApplicationBuilder app)
    //    {
    //        app.UseExceptionHandler(appError =>
    //        {
    //            appError.Run(async context =>
    //            {
    //                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
    //                context.Response.ContentType = "application/json";

    //                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
    //                var contextRequest = context.Features.Get<IHttpRequestFeature>();

    //                if (contextFeature != null)
    //                {
    //                    await context.Response.WriteAsync(new ErrorVM()
    //                    {
    //                        StatusCode = context.Response.StatusCode,
    //                        Message = contextFeature.Error.Message,
    //                        Path = contextRequest.Path
    //                    }.ToString());
    //                }
    //            });
    //        });
    //    }
    //}
}
