using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// Member class
    /// </summary>
    [MetadataType(typeof(MemberMD))]
    public partial class Member
    {
    
    	/// <summary>
    	/// Member Metadata class
    	/// </summary>
    	public class MemberMD
    	{
    		    
    		/// <summary>
    		/// Mem No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int MemNo { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Email
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemEmail", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(256, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string MemEmail { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Pwd
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemPwd", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string MemPwd { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Diminutive
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemDiminutive", typeof(AllShowResource))]
            [MaxLength(40, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string MemDiminutive { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemName", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(40, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string MemName { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Sex
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemSex", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string MemSex { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Tel
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemTel", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string MemTel { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Address
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemAddress", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(80, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string MemAddress { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Pic
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemPic", typeof(AllShowResource))]
            [MaxLength(1000, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string MemPic { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Account State
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemAccountState", typeof(AllShowResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string MemAccountState { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Check Number
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemCheckNumber", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(5, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string MemCheckNumber { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Create Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemCreateDate", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public System.DateTime MemCreateDate { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Birth
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemBirth", typeof(AllShowResource))]
    		public Nullable<System.DateTime> MemBirth { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Update Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemUpdateDate", typeof(AllShowResource))]
    		public Nullable<System.DateTime> MemUpdateDate { get; set; }
    
    		    
    	}
    }
    
}
