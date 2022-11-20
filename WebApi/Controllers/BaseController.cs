using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using Core.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApi.Controllers
{

    //public class NoCache : ActionFilterAttribute
    //{
    //    public override void OnResultExecuting(ResultExecutingContext filterContext)
    //    {
    //        filterContext.HttpContext.Response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1));
    //        filterContext.HttpContext.Response.Cache.SetValidUntilExpires(false);
    //        filterContext.HttpContext.Response.Cache.SetRevalidation(HttpCacheRevalidation.AllCaches);
    //        filterContext.HttpContext.Response.Cache.SetCacheability(HttpCacheability.NoCache);
    //        filterContext.HttpContext.Response.Cache.SetNoStore();

    //        base.OnResultExecuting(filterContext);
    //    }
    //}
    //[NoCache]
    //public class BaseController : ControllerBase
    //{
    //protected override void OnException(ExceptionContext filterContext)
    //{
    //    if (!filterContext.ExceptionHandled)
    //    {
    //        string controller = filterContext.RouteData.Values["controller"].ToString();
    //        string action = filterContext.RouteData.Values["action"].ToString();
    //        Exception ex = filterContext.Exception;
    //        //do something with these details here
    //        RedirectToAction("Error");
    //    }
    //}

    //public ActionResult Error()
    //{
    //    Faranam.Utils.Log.LogAction(TextMessages.Message("10200"));

    //    return PartialView();
    //}

    //protected string RenderPartialViewToString(string viewName, object model)
    //{
    //    Faranam.Utils.Log.LogAction(TextMessages.Message("30005"), new { viewName, model });
    //    try
    //    {
    //        if (string.IsNullOrEmpty(viewName))
    //            viewName = ControllerContext.RouteData.GetRequiredString("action");

    //        ViewData.Model = model;

    //        using (StringWriter sw = new StringWriter())
    //        {
    //            ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
    //            ViewContext viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
    //            viewResult.View.Render(viewContext, sw);

    //            return sw.GetStringBuilder().ToString();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        Faranam.Utils.Log.LogAction(ex, new { viewName, model });

    //        throw;
    //    }
    //}
    //[HttpPost, ValidateHeaderAntiForgeryToken]
    //public ActionResult ExitProgram()
    //{
    //    Faranam.Utils.Log.LogAction(TextMessages.Message("30006"));
    //    //Faranam.MeritPay.UI.StateClass.Session_End();
    //    CommonHelper.CurrentUser.Logout();
    //    string portalpath = ConfigurationManager.AppSettings["PortalPath"];
    //    return new RedirectResult(portalpath);
    //}
    // }
    //[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    //public sealed class ValidateHeaderAntiForgeryTokenAttribute : FilterAttribute, IAuthorizationFilter
    //{
    //    public void OnAuthorization(AuthorizationContext filterContext)
    //    {

    //        try
    //        {
    //            if (filterContext == null)
    //            {
    //                throw new ArgumentNullException("filterContext");
    //            }

    //            var httpContext = filterContext.HttpContext;
    //            var cookie = httpContext.Request.Cookies[AntiForgeryConfig.CookieName];
    //            AntiForgery.Validate(
    //                cookie != null ? cookie.Value : null,
    //                httpContext.Request.Headers["X-RequestVerificationToken"] ?? httpContext.Request.Form["__RequestVerificationToken"]
    //            );
    //        }
    //        catch (Exception)
    //        {

    //            //int i = 0;
    //        }
    //    }
    //}
    public class NeedPermissionAttribute : ActionFilterAttribute
    {
        UserPermission _permission;
        string[] _ids;
        public NeedPermissionAttribute(UserPermission permission, params string[] ids)
        {
            _permission = permission;
            _ids = ids;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (CommonHelper.CurrentUserHasPermission(_permission) && (_ids.Length == 0 || _ids.Any(x => x == CommonHelper.CurrentUser.UserName)))
                base.OnActionExecuting(filterContext);
            else
            {
                filterContext.HttpContext.Response.StatusCode = 403;
                filterContext.Result = new EmptyResult();
            }
        }
    }
}
