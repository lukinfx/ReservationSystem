//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReservationSystemEntityFW
{
    using System;
    using System.Collections.Generic;
    
    public partial class Container
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Goods { get; set; }
        public string NHM { get; set; }
        public string RID { get; set; }
        public decimal Netto { get; set; }
        public decimal Tara { get; set; }
        public decimal Brutto { get; set; }
        public int Wagon_Id { get; set; }
    
        public virtual Wagon Wagon { get; set; }
    }
}