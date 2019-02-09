using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;
using PontoEletronicoMVC.Models.Enums;

namespace PontoEletronicoMVC.Filters
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {
        public String Departamento { get; set; }
        public AutorizacaoFilterAttribute()
        {
            
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            object usuarioId = context.HttpContext.Session.GetString("UserId");
            object usuarioDepartamento = context.HttpContext.Session.GetString("UserDepartamento");

            if (usuarioId == null)
            {

                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new {Controller = "Home", action = "Login"}
                        )
                    );
                return;
            }

            if(Departamento != null)
            {
                if(usuarioDepartamento.ToString() != Departamento.ToString())
                {
                    context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { Controller = "Home", action = "Login" }
                        )
                    );
                }
            }
        }
    }
}
