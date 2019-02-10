using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PontoEletronicoMVC.Models;

namespace PontoEletronicoMVC.Services
{
    public class UsuarioServices
    {
        private readonly PontoEletronicoMVCContext _context;

        public UsuarioServices(PontoEletronicoMVCContext context)
        {
            _context = context;
        }

        public Usuario ValidarLogin(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            Usuario user = _context.Usuario.SingleOrDefault(x => x.Email == email && x.Senha == password);

            if(user == null)
            {
                return null;
            }

            return user;

        }

        public void Insert(Usuario obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Usuario FindById(int id)
        {
            return _context.Usuario.FirstOrDefault(obj => obj.Id == id);
        }



    }
}
