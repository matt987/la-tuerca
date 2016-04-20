using LaTuerca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaTuerca.ViewModels
{
    public class RepuestoViewModel
    {
          public Repuesto Repuesto { get; set; }
          public List<Marca> Marcas { get; set; }
          public List<Proveedor> Proveedores { get; set; }
          public Proveedor Proveedor {get; set;}
          public Marca Marca { get; set; }     

          public RepuestoViewModel(Repuesto _repuesto, List<Marca> _marcas, List<Proveedor> _proveedores )
          {
            Repuesto = _repuesto;
            Marcas= _marcas;
            Proveedores = _proveedores;
            Marca = new Marca();
            Proveedor = new Proveedor();
          }
    }
}