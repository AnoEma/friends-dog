using Microsoft.AspNetCore.Http;

namespace Infra.Extensions;

public static class HttpContextExtensions
{
    public static string GetFormValue(this HttpContext httpContext, string key)
    {
        if (string.IsNullOrEmpty(key)
            || httpContext == null
            || httpContext.Request == null
            || httpContext.Request.Form == null)
        {
            return string.Empty;
        }

        var form = httpContext.Request.Form;

        if (!form.Any() || !httpContext.Request.Form.ContainsKey(key))
        {
            return string.Empty;
        }

        return httpContext.Request.Form[key];
    }
}