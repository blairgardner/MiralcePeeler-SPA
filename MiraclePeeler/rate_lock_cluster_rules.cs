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
    
    public partial class rate_lock_cluster_rules
    {
        public int id { get; set; }
        public int rate_lock_rule_group_id { get; set; }
        public int rate_lock_cluster_id { get; set; }
        public string value { get; set; }
    
        public virtual rate_lock_clusters rate_lock_clusters { get; set; }
        public virtual rate_lock_rule_groups rate_lock_rule_groups { get; set; }
    }
}
