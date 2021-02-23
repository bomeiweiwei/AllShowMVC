using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// ShClass class
    /// </summary>
    [MetadataType(typeof(ShClassMD))]
    public partial class ShClass
    {
    
    	/// <summary>
    	/// ShClass Metadata class
    	/// </summary>
    	public class ShClassMD
    	{
    		    
    		/// <summary>
    		/// Sh Class No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShClassNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int ShClassNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Class Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShClassName", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShClassName { get; set; }
    
    		    
    	}
    }
    
}
