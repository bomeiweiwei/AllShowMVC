using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// OrderList class
    /// </summary>
    [MetadataType(typeof(OrderListMD))]
    public partial class OrderList
    {
    
    	/// <summary>
    	/// OrderList Metadata class
    	/// </summary>
    	public class OrderListMD
    	{
    		    
    		/// <summary>
    		/// Shoporder No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShoporderNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int ShoporderNo { get; set; }
    
    		    
    		/// <summary>
    		/// Pro No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int ProNo { get; set; }
    
    		    
    		/// <summary>
    		/// Quantity
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Quantity", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public int Quantity { get; set; }
    
    		    
    	}
    }
    
}
