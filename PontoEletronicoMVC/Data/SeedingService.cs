﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PontoEletronicoMVC.Models;
using PontoEletronicoMVC.Models.Enums;


namespace PontoEletronicoMVC.Data
{
    public class SeedingService
    {

        private PontoEletronicoMVCContext _context;

        public SeedingService(PontoEletronicoMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Usuario.Any())
            {
                return;
            }

            Usuario u1 = new Usuario(1, "Bob Brown", "Ti@gmail.com", "123456", Departamentos.Ti, new TimeSpan(7, 30, 00), new TimeSpan(11, 30, 00), new TimeSpan(13, 30, 00), new TimeSpan(17, 30, 00));
            Usuario u2 = new Usuario(2, "Alex Grey", "Rh@gmail.com", "123456", Departamentos.Rh, new TimeSpan(7, 30, 00), new TimeSpan(11, 30, 00), new TimeSpan(13, 30, 00), new TimeSpan(17, 30, 00));

            _context.Usuario.AddRange(u1, u2);

            _context.SaveChanges();

        }
    }
}
