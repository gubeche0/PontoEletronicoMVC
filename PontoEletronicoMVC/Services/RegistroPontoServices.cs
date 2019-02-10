using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PontoEletronicoMVC.Models;

namespace PontoEletronicoMVC.Services
{
    public class RegistroPontoServices
    {

        private readonly PontoEletronicoMVCContext _context;

        public RegistroPontoServices(PontoEletronicoMVCContext context)
        {
            _context = context;
        }


        public void Insert(RegistroPonto obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public RegistroPonto FindById(int id)
        {
            
            return _context.RegistroPonto.FirstOrDefault(obj => obj.Id == id);
        }



    }
}
