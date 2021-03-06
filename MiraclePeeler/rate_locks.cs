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
    
    public partial class rate_locks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rate_locks()
        {
            this.rate_lock_import_history = new HashSet<rate_lock_import_history>();
            this.rate_lock_import_history1 = new HashSet<rate_lock_import_history>();
        }
    
        public int id { get; set; }
        public int loan_id { get; set; }
        public int user_id { get; set; }
        public System.DateTime date { get; set; }
        public decimal rate { get; set; }
        public int period { get; set; }
        public int lock_duration { get; set; }
        public byte rate_lock_status_id { get; set; }
        public byte rate_lock_type_id { get; set; }
        public int rate_lock_pricing_sheet_id { get; set; }
        public int rate_lock_rule_version_id { get; set; }
        public int rate_lock_cluster_id { get; set; }
        public decimal undiscounted_rate { get; set; }
        public decimal base_price { get; set; }
        public decimal adjusted_price { get; set; }
        public System.DateTime expiration_date { get; set; }
        public Nullable<int> days_extended { get; set; }
        public Nullable<decimal> extension_cost { get; set; }
        public string product_code { get; set; }
        public Nullable<decimal> discount_paid_by_borrower { get; set; }
        public string exception_category { get; set; }
        public string exception_note { get; set; }
        public Nullable<System.DateTime> cancel_date { get; set; }
        public Nullable<int> cancelled_by { get; set; }
        public decimal investor_pricing { get; set; }
        public decimal srp { get; set; }
        public byte update_to_encompass_status_id { get; set; }
        public Nullable<bool> is_branch { get; set; }
    
        public virtual rate_lock_clusters rate_lock_clusters { get; set; }
        public virtual rate_lock_encompass_statuses rate_lock_encompass_statuses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rate_lock_import_history> rate_lock_import_history { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rate_lock_import_history> rate_lock_import_history1 { get; set; }
        public virtual rate_lock_pricing_sheet rate_lock_pricing_sheet { get; set; }
        public virtual rate_lock_rule_versions rate_lock_rule_versions { get; set; }
        public virtual rate_lock_statuses rate_lock_statuses { get; set; }
        public virtual rate_lock_types rate_lock_types { get; set; }
    }
}
