//using slnMyStudy.Common;
//using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


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
    	    [DisplayName("AuthorityNo")]
            [Required(ErrorMessage = "Authority No is required")]
            [Key]
    		public int AuthorityNo { get; set; }
    
    		    
    		/// <summary>
    		/// Authority Name
    		/// </summary>        
    	    [DisplayName("AuthorityName")]
            [Required(ErrorMessage = "Authority Name is required")]
            [MaxLength(40, ErrorMessage = "Authority Name cannot be longer than 40 characters")]
    		public string AuthorityName { get; set; }
    
    		    
    	}
    }
    
}
