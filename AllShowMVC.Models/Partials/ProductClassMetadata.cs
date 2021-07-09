using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// ProductClass class
    /// </summary>
    [MetadataType(typeof(ProductClassMD))]
    public partial class ProductClass
    {
    
    	/// <summary>
    	/// ProductClass Metadata class
    	/// </summary>
    	public class ProductClassMD
    	{
    		    
    		/// <summary>
    		/// Pro Class No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProClassNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int ProClassNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShNo", typeof(AllShowResource))]
    		public Nullable<int> ShNo { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Class Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProClassName", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ProClassName { get; set; }
    
    		    
    	}
    }
    
}
