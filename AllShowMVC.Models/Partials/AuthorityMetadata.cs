//using slnMyStudy.Common;
//using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// Authority class
    /// </summary>
    [MetadataType(typeof(AuthorityMD))]
    public partial class Authority
    {
    
    	/// <summary>
    	/// Authority Metadata class
    	/// </summary>
    	public class AuthorityMD
    	{
    		    
    		/// <summary>
    		/// Authority No
    		/// </summary>        
    	    [DisplayName("AuthorityNo")]
            [Required(ErrorMessage = "Authority No is required")]
            [Key]
    		public int AuthorityNo { get; set; }
    
    		    
    		/// <summary>
    		/// Emp No
    		/// </summary>        
    	    [DisplayName("EmpNo")]
            [Required(ErrorMessage = "Emp No is required")]
            [Key]
    		public int EmpNo { get; set; }
    
    		    
    		/// <summary>
    		/// Note
    		/// </summary>        
    	    [DisplayName("Note")]
            [MaxLength(10, ErrorMessage = "Note cannot be longer than 10 characters")]
    		public string Note { get; set; }
    
    		    
    	}
    }
    
}
