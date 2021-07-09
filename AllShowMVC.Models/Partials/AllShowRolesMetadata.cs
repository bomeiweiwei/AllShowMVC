using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// AllShowRoles class
    /// </summary>
    [MetadataType(typeof(AllShowRolesMD))]
    public partial class AllShowRoles
    {
    
    	/// <summary>
    	/// AllShowRoles Metadata class
    	/// </summary>
    	public class AllShowRolesMD
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
    		/// Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Name", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(256, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string Name { get; set; }
    
    		    
    	}
    }
    
}
