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
    
    public partial class Request
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Approved { get; set; }
        public string Description { get; set; }
        public decimal Lenght { get; set; }
        public decimal Height { get; set; }
        public decimal Depth { get; set; }
        public decimal Weight { get; set; }
        public System.DateTime SubmitDate { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public string Email { get; set; }
        public int TrainId { get; set; }
    
        public virtual Train Train { get; set; }
    }
}
