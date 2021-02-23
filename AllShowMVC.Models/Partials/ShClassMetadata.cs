//using slnMyStudy.Common;
//using slnMyStudy.Resource.App_GlobalResources;
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
    	    [DisplayName("ShClassNo")]
            [Required(ErrorMessage = "Sh Class No is required")]
            [Key]
    		public int ShClassNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Class Name
    		/// </summary>        
    	    [DisplayName("ShClassName")]
            [Required(ErrorMessage = "Sh Class Name is required")]
            [MaxLength(20, ErrorMessage = "Sh Class Name cannot be longer than 20 characters")]
    		public string ShClassName { get; set; }
    
    		    
    	}
    }
    
}
