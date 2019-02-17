using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontoEletronicoMVC.Models
{
    public class RegistroPonto
    {
        public int Id { get; set; }

        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public TimeSpan TotalTempo { get; set; }

        public RegistroPonto()
        {

        }

        public RegistroPonto(int id, DateTime entrada, DateTime saida, Usuario usuario, TimeSpan totalTempo)
        {
            Id = id;
            Entrada = entrada;
            Saida = saida;
            Usuario = usuario;
            TotalTempo = totalTempo;
        }
    }
}
