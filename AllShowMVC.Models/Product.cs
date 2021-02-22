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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderList = new HashSet<OrderList>();
        }
    
        public int ProNo { get; set; }
        public Nullable<int> ShNo { get; set; }
        public Nullable<int> ProClassNo { get; set; }
        public string ProName { get; set; }
        public int ProPrice { get; set; }
        public string ProStatement { get; set; }
        public string ProState { get; set; }
        public string ProPic1 { get; set; }
        public string ProPic2 { get; set; }
        public string ProPic3 { get; set; }
        public Nullable<System.DateTime> ProCreateDate { get; set; }
        public Nullable<System.DateTime> ProUpdateDate { get; set; }
        public Nullable<System.DateTime> ProOffshelfDate { get; set; }
        public string ProPop { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderList> OrderList { get; set; }
        public virtual ProductClass ProductClass { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
