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
    
    public partial class rate_lock_rules
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rate_lock_rules()
        {
            this.rate_lock_rule_values = new HashSet<rate_lock_rule_values>();
        }
    
        public int id { get; set; }
        public int rate_lock_rule_group_id { get; set; }
        public byte rate_lock_field_id { get; set; }
        public byte rate_lock_operator_id { get; set; }
        public string compare_value { get; set; }
    
        public virtual rate_lock_fields rate_lock_fields { get; set; }
        public virtual rate_lock_operators rate_lock_operators { get; set; }
        public virtual rate_lock_rule_groups rate_lock_rule_groups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rate_lock_rule_values> rate_lock_rule_values { get; set; }
    }
}
