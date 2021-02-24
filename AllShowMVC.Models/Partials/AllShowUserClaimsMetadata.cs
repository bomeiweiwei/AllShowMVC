using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// AllShowUserClaims class
    /// </summary>
    [MetadataType(typeof(AllShowUserClaimsMD))]
    public partial class AllShowUserClaims
    {
    
    	/// <summary>
    	/// AllShowUserClaims Metadata class
    	/// </summary>
    	public class AllShowUserClaimsMD
    	{
    		    
    		/// <summary>
    		/// Id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Id", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int Id { get; set; }
    
    		    
    		/// <summary>
    		/// User Id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("UserId", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(128, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string UserId { get; set; }
    
    		    
    		/// <summary>
    		/// Claim Type
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ClaimType", typeof(AllShowResource))]
    		public string ClaimType { get; set; }
    
    		    
    		/// <summary>
    		/// Claim Value
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ClaimValue", typeof(AllShowResource))]
    		public string ClaimValue { get; set; }
    
    		    
    	}
    }
    
}
