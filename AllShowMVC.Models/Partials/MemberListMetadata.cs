//using slnMyStudy.Common;
//using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// MemberList class
    /// </summary>
    [MetadataType(typeof(MemberListMD))]
    public partial class MemberList
    {
    
    	/// <summary>
    	/// MemberList Metadata class
    	/// </summary>
    	public class MemberListMD
    	{
    		    
    		/// <summary>
    		/// Order No
    		/// </summary>        
    	    [DisplayName("OrderNo")]
            [Required(ErrorMessage = "Order No is required")]
            [Key]
    		public int OrderNo { get; set; }
    
    		    
    		/// <summary>
    		/// Mem No
    		/// </summary>        
    	    [DisplayName("MemNo")]
    		public Nullable<int> MemNo { get; set; }
    
    		    
    		/// <summary>
    		/// Order Date
    		/// </summary>        
    	    [DisplayName("OrderDate")]
    		public Nullable<System.DateTime> OrderDate { get; set; }
    
    		    
    	}
    }
    
}
