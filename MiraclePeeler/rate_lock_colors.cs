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
    
    public partial class rate_lock_colors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rate_lock_colors()
        {
            this.rate_lock_notifications = new HashSet<rate_lock_notifications>();
        }
    
        public byte id { get; set; }
        public string hex_code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rate_lock_notifications> rate_lock_notifications { get; set; }
    }
}
