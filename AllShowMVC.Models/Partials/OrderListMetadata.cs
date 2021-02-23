//using slnMyStudy.Common;
//using slnMyStudy.Resource.App_GlobalResources;
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
    	    [DisplayName("ShoporderNo")]
            [Required(ErrorMessage = "Shoporder No is required")]
            [Key]
    		public int ShoporderNo { get; set; }
    
    		    
    		/// <summary>
    		/// Pro No
    		/// </summary>        
    	    [DisplayName("ProNo")]
            [Required(ErrorMessage = "Pro No is required")]
            [Key]
    		public int ProNo { get; set; }
    
    		    
    		/// <summary>
    		/// Quantity
    		/// </summary>        
    	    [DisplayName("Quantity")]
            [Required(ErrorMessage = "Quantity is required")]
    		public int Quantity { get; set; }
    
    		    
    	}
    }
    
}
