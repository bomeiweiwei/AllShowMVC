using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


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
    	    [ResourceTool.LocalizedDisplayName("AuthorityNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
            [Column(Order = 1)]
    		public int AuthorityNo { get; set; }
    
    		    
    		/// <summary>
    		/// Emp No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmpNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
            [Column(Order = 0)]
    		public int EmpNo { get; set; }
    
    		    
    		/// <summary>
    		/// Note
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Note", typeof(AllShowResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string Note { get; set; }
    
    		    
    	}
    }
    
}
