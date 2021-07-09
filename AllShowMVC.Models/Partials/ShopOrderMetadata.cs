using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


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
    	    [ResourceTool.LocalizedDisplayName("ShoporderNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int ShoporderNo { get; set; }
    
    		    
    		/// <summary>
    		/// Order No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("OrderNo", typeof(AllShowResource))]
    		public Nullable<int> OrderNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShNo", typeof(AllShowResource))]
    		public Nullable<int> ShNo { get; set; }
    
    		    
    		/// <summary>
    		/// Order Price
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("OrderPrice", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public int OrderPrice { get; set; }
    
    		    
    		/// <summary>
    		/// Referred To Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ReferredToDate", typeof(AllShowResource))]
    		public Nullable<System.DateTime> ReferredToDate { get; set; }
    
    		    
    		/// <summary>
    		/// Transaction Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("TransactionDate", typeof(AllShowResource))]
    		public Nullable<System.DateTime> TransactionDate { get; set; }
    
    		    
    		/// <summary>
    		/// Order State
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("OrderState", typeof(AllShowResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string OrderState { get; set; }
    
    		    
    		/// <summary>
    		/// Recipient Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("RecipientName", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string RecipientName { get; set; }
    
    		    
    		/// <summary>
    		/// Recipient Tel
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("RecipientTel", typeof(AllShowResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string RecipientTel { get; set; }
    
    		    
    		/// <summary>
    		/// Recipient Address
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("RecipientAddress", typeof(AllShowResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string RecipientAddress { get; set; }
    
    		    
    		/// <summary>
    		/// Pay Type
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("PayType", typeof(AllShowResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string PayType { get; set; }
    
    		    
    	}
    }
    
}
