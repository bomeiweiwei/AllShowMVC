using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
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
    	    [ResourceTool.LocalizedDisplayName("OrderNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int OrderNo { get; set; }
    
    		    
    		/// <summary>
    		/// Mem No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemNo", typeof(AllShowResource))]
    		public Nullable<int> MemNo { get; set; }
    
    		    
    		/// <summary>
    		/// Order Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("OrderDate", typeof(AllShowResource))]
    		public Nullable<System.DateTime> OrderDate { get; set; }
    
    		    
    	}
    }
    
}
