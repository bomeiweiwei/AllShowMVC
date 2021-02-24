using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// AllShowUsers class
    /// </summary>
    [MetadataType(typeof(AllShowUsersMD))]
    public partial class AllShowUsers
    {
    
    	/// <summary>
    	/// AllShowUsers Metadata class
    	/// </summary>
    	public class AllShowUsersMD
    	{
    		    
    		/// <summary>
    		/// Id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Id", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(128, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public string Id { get; set; }
    
    		    
    		/// <summary>
    		/// Email
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Email", typeof(AllShowResource))]
            [MaxLength(256, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string Email { get; set; }
    
    		    
    		/// <summary>
    		/// Email Confirmed
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmailConfirmed", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public bool EmailConfirmed { get; set; }
    
    		    
    		/// <summary>
    		/// Password Hash
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("PasswordHash", typeof(AllShowResource))]
    		public string PasswordHash { get; set; }
    
    		    
    		/// <summary>
    		/// Security Stamp
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("SecurityStamp", typeof(AllShowResource))]
    		public string SecurityStamp { get; set; }
    
    		    
    		/// <summary>
    		/// Phone Number
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("PhoneNumber", typeof(AllShowResource))]
    		public string PhoneNumber { get; set; }
    
    		    
    		/// <summary>
    		/// Phone Number Confirmed
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("PhoneNumberConfirmed", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public bool PhoneNumberConfirmed { get; set; }
    
    		    
    		/// <summary>
    		/// Two Factor Enabled
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("TwoFactorEnabled", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public bool TwoFactorEnabled { get; set; }
    
    		    
    		/// <summary>
    		/// Lockout End Date Utc
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("LockoutEndDateUtc", typeof(AllShowResource))]
    		public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
    
    		    
    		/// <summary>
    		/// Lockout Enabled
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("LockoutEnabled", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public bool LockoutEnabled { get; set; }
    
    		    
    		/// <summary>
    		/// Access Failed Count
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("AccessFailedCount", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public int AccessFailedCount { get; set; }
    
    		    
    		/// <summary>
    		/// User Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("UserName", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(256, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string UserName { get; set; }
    
    		    
    	}
    }
    
}
