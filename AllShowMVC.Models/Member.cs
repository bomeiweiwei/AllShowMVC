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
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.FavoriteShopList = new HashSet<FavoriteShopList>();
            this.MemberList = new HashSet<MemberList>();
        }
    
        public int MemNo { get; set; }
        public string MemEmail { get; set; }
        public string MemPwd { get; set; }
        public string MemDiminutive { get; set; }
        public string MemName { get; set; }
        public string MemSex { get; set; }
        public string MemTel { get; set; }
        public string MemAddress { get; set; }
        public string MemPic { get; set; }
        public string MemAccountState { get; set; }
        public string MemCheckNumber { get; set; }
        public System.DateTime MemCreateDate { get; set; }
        public Nullable<System.DateTime> MemBirth { get; set; }
        public Nullable<System.DateTime> MemUpdateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoriteShopList> FavoriteShopList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberList> MemberList { get; set; }
    }
}
