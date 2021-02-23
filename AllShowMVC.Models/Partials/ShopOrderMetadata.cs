//using slnMyStudy.Common;
//using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// ShopOrder class
    /// </summary>
    [MetadataType(typeof(ShopOrderMD))]
    public partial class ShopOrder
    {
    
    	/// <summary>
    	/// ShopOrder Metadata class
    	/// </summary>
    	public class ShopOrderMD
    	{
    		    
    		/// <summary>
    		/// Shoporder No
    		/// </summary>        
    	    [DisplayName("ShoporderNo")]
            [Required(ErrorMessage = "Shoporder No is required")]
            [Key]
    		public int ShoporderNo { get; set; }
    
    		    
    		/// <summary>
    		/// Order No
    		/// </summary>        
    	    [DisplayName("OrderNo")]
    		public Nullable<int> OrderNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh No
    		/// </summary>        
    	    [DisplayName("ShNo")]
    		public Nullable<int> ShNo { get; set; }
    
    		    
    		/// <summary>
    		/// Order Price
    		/// </summary>        
    	    [DisplayName("OrderPrice")]
            [Required(ErrorMessage = "Order Price is required")]
    		public int OrderPrice { get; set; }
    
    		    
    		/// <summary>
    		/// Referred To Date
    		/// </summary>        
    	    [DisplayName("ReferredToDate")]
    		public Nullable<System.DateTime> ReferredToDate { get; set; }
    
    		    
    		/// <summary>
    		/// Transaction Date
    		/// </summary>        
    	    [DisplayName("TransactionDate")]
    		public Nullable<System.DateTime> TransactionDate { get; set; }
    
    		    
    		/// <summary>
    		/// Order State
    		/// </summary>        
    	    [DisplayName("OrderState")]
            [MaxLength(1, ErrorMessage = "Order State cannot be longer than 1 characters")]
    		public string OrderState { get; set; }
    
    		    
    		/// <summary>
    		/// Recipient Name
    		/// </summary>        
    	    [DisplayName("RecipientName")]
            [Required(ErrorMessage = "Recipient Name is required")]
            [MaxLength(20, ErrorMessage = "Recipient Name cannot be longer than 20 characters")]
    		public string RecipientName { get; set; }
    
    		    
    		/// <summary>
    		/// Recipient Tel
    		/// </summary>        
    	    [DisplayName("RecipientTel")]
            [MaxLength(10, ErrorMessage = "Recipient Tel cannot be longer than 10 characters")]
    		public string RecipientTel { get; set; }
    
    		    
    		/// <summary>
    		/// Recipient Address
    		/// </summary>        
    	    [DisplayName("RecipientAddress")]
            [MaxLength(50, ErrorMessage = "Recipient Address cannot be longer than 50 characters")]
    		public string RecipientAddress { get; set; }
    
    		    
    		/// <summary>
    		/// Pay Type
    		/// </summary>        
    	    [DisplayName("PayType")]
            [MaxLength(1, ErrorMessage = "Pay Type cannot be longer than 1 characters")]
    		public string PayType { get; set; }
    
    		    
    	}
    }
    
}
