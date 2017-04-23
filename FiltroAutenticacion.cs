using System;
using System.Collection.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarritoCompras.Filters
{
  public class FiltroAutenticacion:ActionFilterAttribute 
  {
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
    object cliente = filterContext.HttpContext.Session["Cliente"];
    if (cliente==null)filterContextResult = new RedirectResult("~/ConsultaLogin");
    }
  }
}  
