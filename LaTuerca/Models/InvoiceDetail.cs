using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LaTuerca.Models
{
    public class InvoiceDetail
    {
        public int Id { get; set; }

        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public int InvoiceId { get; set; }
        public int RepuestoId { get; set; }

        [ForeignKey("InvoiceId")]
        public virtual Invoice Invoice { get; set; }

        [ForeignKey("RepuestoId")]
        public virtual Repuesto Repuesto { get; set; }
    }
}