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
    
    public partial class Wagon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wagon()
        {
            this.Container = new HashSet<Container>();
        }
    
        public int Id { get; set; }
        public int NL_Id { get; set; }
        public int WagonType_Id { get; set; }
    
        public virtual NL NL { get; set; }
        public virtual WagonType WagonType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Container> Container { get; set; }
    }
}
