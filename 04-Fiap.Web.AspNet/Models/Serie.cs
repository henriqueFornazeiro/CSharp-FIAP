using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _04_Fiap.Web.AspNet.Models
{
    [Table("Table_Serie")]
    public class Serie
    {
        [Column("Id"), HiddenInput]
        public int SerieId { get; set; }

        [Column("nm_serie"), Required, MaxLength(50)]
        public string Nome { get; set; }

        public Genero Tipo { get; set; }

        [Display(Name = "Data de Lançamento"), Required, DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Column("Temporada")]
        public int Temporadas { get; set; }
    }
}
