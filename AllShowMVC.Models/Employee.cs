//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AllShowMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Advertisement = new HashSet<Advertisement>();
            this.Announcement = new HashSet<Announcement>();
            this.Authority = new HashSet<Authority>();
            this.Shop = new HashSet<Shop>();
        }
    
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string EmpAccount { get; set; }
        public string EmpPwd { get; set; }
        public string EmpEmail { get; set; }
        public string EmpSex { get; set; }
        public System.DateTime EmpBirth { get; set; }
        public string EmpTel { get; set; }
        public System.DateTime HireDate { get; set; }
        public Nullable<System.DateTime> LeaveDate { get; set; }
        public string EmpAccountState { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Advertisement> Advertisement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Announcement> Announcement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Authority> Authority { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop> Shop { get; set; }
    }
}
