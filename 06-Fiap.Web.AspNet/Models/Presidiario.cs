using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    public class Presidiario
    {

        public int PresidiarioId { get; set; }
        public string  Nome { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public NivelEscolaridade NivelEscolaridade { get; set; }
        public bool SaidaTemporaria { get; set; }

        public Cela Cela { get; set; }
        public int CelaId { get; set; }

    }
}
