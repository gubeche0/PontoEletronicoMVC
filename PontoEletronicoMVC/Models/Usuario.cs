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

        public Usuario(int id, string nome, string email, string senha, Departamentos departamento, TimeSpan entryAm, TimeSpan exitAm, TimeSpan entryPm, TimeSpan exitPm)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Departamento = departamento;
            EntryAm = entryAm;
            ExitAm = exitAm;
            EntryPm = entryPm;
            ExitPm = exitPm;
        }
    }
}
