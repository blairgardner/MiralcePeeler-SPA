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
    
    public partial class rate_lock_folders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rate_lock_folders()
        {
            this.rate_lock_rule_groups = new HashSet<rate_lock_rule_groups>();
        }
    
        public int id { get; set; }
        public byte rate_lock_rule_type_id { get; set; }
        public int rate_lock_rule_version_id { get; set; }
        public string name { get; set; }
    
        public virtual rate_lock_rule_versions rate_lock_rule_versions { get; set; }
        public virtual rate_lock_rule_types rate_lock_rule_types { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rate_lock_rule_groups> rate_lock_rule_groups { get; set; }
    }
}