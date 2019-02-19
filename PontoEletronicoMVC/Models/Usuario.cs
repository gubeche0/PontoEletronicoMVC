using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PontoEletronicoMVC.Models.Enums;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

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

        [Required(ErrorMessage = "{0} é obrigatório")]
        [DataType(DataType.Time)]
        [Display(Name ="Entrada 1")]
        public TimeSpan EntryAm { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [DataType(DataType.Time)]
        [Display(Name = "Saida 1")]
        public TimeSpan ExitAm { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [DataType(DataType.Time)]
        [Display(Name = "Entrada 2")]
        public TimeSpan EntryPm { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
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

        public TimeSpan CargaHoraria()
        {
            return (ExitAm - EntryAm + ExitPm - EntryPm);
        }

        public int DiasTrabalhados(DateTime initial, DateTime final)
        {
            return Pontos.Where(pt => pt.Saida.Date >= initial && pt.Saida.Date <= final).Distinct((pt1, pt2) => pt1.Entrada.Date == pt2.Entrada.Date).Count();
        }

        public TimeSpan TotalHoras(DateTime initial, DateTime final)
        {
            
            long ticks = Pontos.Where(pt => pt.Entrada.Date >= initial && pt.Saida.Date <= final).Sum(pt => pt.TotalTempo.Ticks);
            TimeSpan time = new TimeSpan(ticks);
            return time;
        }

        public TimeSpan TotalHorasExtra(DateTime initial, DateTime final)
        {
            return TotalHoras(initial, final) - CargaHoraria().Multiply(DiasTrabalhados(initial, final));
        }

    }
}
