using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PontoEletronicoMVC.Models.Enums;

namespace PontoEletronicoMVC.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Departamentos Departamento { get; set; }

        public TimeSpan EntryAm { get; set; }
        public TimeSpan ExitAm { get; set; }
        public TimeSpan EntryPm { get; set; }
        public TimeSpan ExitPm { get; set; }

        public Usuario()
        {
        }


    }
}
