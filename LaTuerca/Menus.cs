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
    
    public partial class Menus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public bool Active { get; set; }
    }
}