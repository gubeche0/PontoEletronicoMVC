using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PontoEletronicoMVC.Services;
using PontoEletronicoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using PontoEletronicoMVC.Filters;

namespace PontoEletronicoMVC.Controllers
{
    public class RegistroPontosController : Controller
    {
        private readonly RegistroPontoServices _registroPontoServices;
        private readonly UsuarioServices _usuarioServices;

        public RegistroPontosController(RegistroPontoServices registroPontoServices, UsuarioServices usuarioServices)
        {
            _registroPontoServices = registroPontoServices;
            _usuarioServices = usuarioServices;
        }
        [AutorizacaoFilter]
        public IActionResult Index()
        {
            int id = int.Parse(HttpContext.Session.GetString("UserId"));
            Usuario user = _usuarioServices.FindById(id);
            var list = _registroPontoServices.FindAll(user);
            return View(list);
        }
    }
}
