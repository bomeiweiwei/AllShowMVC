using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// AuthorityFunction class
    /// </summary>
    [MetadataType(typeof(AuthorityFunctionMD))]
    public partial class AuthorityFunction
    {
    
    	/// <summary>
    	/// AuthorityFunction Metadata class
    	/// </summary>
    	public class AuthorityFunctionMD
    	{
    		    
    		/// <summary>
    		/// Authority No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("AuthorityNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int AuthorityNo { get; set; }
    
    		    
    		/// <summary>
    		/// Authority Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("AuthorityName", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(40, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string AuthorityName { get; set; }
    
    		    
    	}
    }
    
}
