using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    public class Cela
    {

        public int CelaId { get; set; }
        public string Nome { get; set; }
        public float AreaUtil { get; set; }
        public int QuantMaxima { get; set; }

        public IList<Presidiario> Presidiarios { get; set; }

    }
}
