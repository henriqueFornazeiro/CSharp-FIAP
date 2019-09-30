using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    [Table("T_Condominio")]
    public class Condominio
    {
        [HiddenInput] 
        public int CondominioId { get; set; }
        [Column("Nm_Condominio")]
        public string Nome { get; set; }
        [Column("Qtd_Blocos")]
        public int Blocos { get; set; }
        [Column("Ds_Ativo")]
        public bool Ativo { get; set; }
        [Column("Ds_Tipo")]
        public Tipo Tipo { get; set; }

        //Relacionamento
        public Sindico Sindico { get; set; }
        public int SindicoId { get; set; }

        public IList<Imovel> Imoveis { get; set; }

        public IList<CondominioConstrutora> CondominioConstrutoras { get; set; }

    }
}
