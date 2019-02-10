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
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public Departamentos Departamento { get; set; }

        [DataType(DataType.Time)]
        [Display(Name ="Entrada 1")]
        public TimeSpan EntryAm { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Saida 1")]
        public TimeSpan ExitAm { get; set; }

        [Required(AllowEmptyStrings =false)]
        [DataType(DataType.Time)]
        [Display(Name = "Entrada 2")]
        public TimeSpan EntryPm { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Saida 2")]
        public TimeSpan ExitPm { get; set; }

        public ICollection<RegistroPonto> Pontos { get; set; }

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

        public void AddRegistroPonto(RegistroPonto obj)
        {
            Pontos.Add(obj);
        }

        public void RemoveRegistroPonto(RegistroPonto obj)
        {
            Pontos.Remove(obj);
        }
    }
}
