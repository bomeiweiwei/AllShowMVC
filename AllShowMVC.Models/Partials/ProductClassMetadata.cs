//using slnMyStudy.Common;
//using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


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
    	    [DisplayName("ProClassNo")]
            [Required(ErrorMessage = "Pro Class No is required")]
            [Key]
    		public int ProClassNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh No
    		/// </summary>        
    	    [DisplayName("ShNo")]
    		public Nullable<int> ShNo { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Class Name
    		/// </summary>        
    	    [DisplayName("ProClassName")]
            [Required(ErrorMessage = "Pro Class Name is required")]
            [MaxLength(20, ErrorMessage = "Pro Class Name cannot be longer than 20 characters")]
    		public string ProClassName { get; set; }
    
    		    
    	}
    }
    
}
