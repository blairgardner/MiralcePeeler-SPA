//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiraclePeeler
{
    using System;
    using System.Collections.Generic;
    
    public partial class rate_lock_pricing_sheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rate_lock_pricing_sheet()
        {
            this.rate_lock_pricing_sheet_values = new HashSet<rate_lock_pricing_sheet_values>();
            this.rate_locks = new HashSet<rate_locks>();
        }
    
        public int id { get; set; }
        public System.DateTime date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rate_lock_pricing_sheet_values> rate_lock_pricing_sheet_values { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rate_locks> rate_locks { get; set; }
    }
}