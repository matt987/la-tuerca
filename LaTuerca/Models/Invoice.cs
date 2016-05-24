using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTuerca.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar la fecha")]
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }


        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<InvoiceDetail> Details { get; set; }
    }
}