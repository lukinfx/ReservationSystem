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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Request()
        {
            this.NL = new HashSet<NL>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Approved { get; set; }
        public System.DateTime SubmitDate { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public string Email { get; set; }
        public int Train_Id { get; set; }
        public string Reexpedition_Id { get; set; }
        public string StartStation { get; set; }
        public string EndStation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NL> NL { get; set; }
        public virtual Train Train { get; set; }
    }
}
