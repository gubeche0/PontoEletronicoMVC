using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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



        public List<RegistroPonto> FindAll()
        {
            return _context.RegistroPonto.ToList();
        }

        public List<RegistroPonto> FindAll(Usuario user)
        {
            return _context.RegistroPonto.Where(pt => pt.Usuario.Id == user.Id).ToList();
        }

        public void Insert(RegistroPonto obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public RegistroPonto FindById(int id)
        {

            return _context.RegistroPonto.Include(obj => obj.Usuario).FirstOrDefault(obj => obj.Id == id);
        }

        public RegistroPonto FindByDayWithoutSaida(DateTime data, Usuario usuario)
        {

            return _context.RegistroPonto.Include(obj => obj.Usuario).FirstOrDefault(obj => obj.Entrada.Date == data.Date && obj.Saida == new DateTime() && obj.Usuario == usuario);
        }

        public void Update(RegistroPonto obj)
        {
            if (_context.RegistroPonto.Any(x => x.Id == obj.Id))
            {
                _context.Update(obj);
                _context.SaveChanges();
            }

        }
    }

}

