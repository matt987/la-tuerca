//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaTuerca
{
    using System;
    using System.Collections.Generic;
    
    public partial class Repuestoes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Marca_Id { get; set; }
        public Nullable<int> Proveedor_Id { get; set; }
    
        public virtual Marcas Marcas { get; set; }
        public virtual Proveedors Proveedors { get; set; }
    }
}
