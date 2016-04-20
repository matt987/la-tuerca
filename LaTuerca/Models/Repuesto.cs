using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTuerca.Models
{
    public class Repuesto
    {
        [HiddenInput(DisplayValue = true)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre")]
        [StringLength(60, MinimumLength = 3)]
        public string Nombre { get; set; }
        

        public int ProveedorId { get; set; }
        public int MarcaId { get; set; }

        [ForeignKey("ProveedorId")]
        public virtual Proveedor Proveedor { get; set; }

        [ForeignKey("MarcaId")]
        public virtual Marca Marca { get; set; }

    }
}