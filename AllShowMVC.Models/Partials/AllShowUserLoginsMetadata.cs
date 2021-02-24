using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// AllShowUserLogins class
    /// </summary>
    [MetadataType(typeof(AllShowUserLoginsMD))]
    public partial class AllShowUserLogins
    {
    
    	/// <summary>
    	/// AllShowUserLogins Metadata class
    	/// </summary>
    	public class AllShowUserLoginsMD
    	{
    		    
    		/// <summary>
    		/// Login Provider
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("LoginProvider", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(128, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public string LoginProvider { get; set; }
    
    		    
    		/// <summary>
    		/// Provider Key
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProviderKey", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(128, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public string ProviderKey { get; set; }
    
    		    
    		/// <summary>
    		/// User Id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("UserId", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(128, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public string UserId { get; set; }
    
    		    
    	}
    }
    
}
