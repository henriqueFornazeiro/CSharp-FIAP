using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    public class Imovel
    {

        public int ImovelId { get; set; }
        public string Numero { get; set; }
        public float AreaUtil { get; set; }
        
        //Relacionamento
        public Condominio Condominio { get; set; }
        public int CondominioId { get; set; }

    }
}
