using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PontoEletronicoMVC.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace PontoEletronicoMVC.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "{0} é obrigatório")]
        [EmailAddress(ErrorMessage = "Entre com um email válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(80, MinimumLength = 6, ErrorMessage = "{0} size should be between {2} and {1}")]
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
