using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// Product class
    /// </summary>
    [MetadataType(typeof(ProductMD))]
    public partial class Product
    {
    
    	/// <summary>
    	/// Product Metadata class
    	/// </summary>
    	public class ProductMD
    	{
    		    
    		/// <summary>
    		/// Pro No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int ProNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShNo", typeof(AllShowResource))]
    		public Nullable<int> ShNo { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Class No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProClassNo", typeof(AllShowResource))]
    		public Nullable<int> ProClassNo { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProName", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ProName { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Price
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProPrice", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public int ProPrice { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Statement
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProStatement", typeof(AllShowResource))]
            [MaxLength(200, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ProStatement { get; set; }
    
    		    
    		/// <summary>
    		/// Pro State
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProState", typeof(AllShowResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ProState { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Pic1
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProPic1", typeof(AllShowResource))]
            [MaxLength(1000, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ProPic1 { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Pic2
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProPic2", typeof(AllShowResource))]
            [MaxLength(1000, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ProPic2 { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Pic3
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProPic3", typeof(AllShowResource))]
            [MaxLength(1000, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ProPic3 { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Create Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProCreateDate", typeof(AllShowResource))]
    		public Nullable<System.DateTime> ProCreateDate { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Update Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProUpdateDate", typeof(AllShowResource))]
    		public Nullable<System.DateTime> ProUpdateDate { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Offshelf Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProOffshelfDate", typeof(AllShowResource))]
    		public Nullable<System.DateTime> ProOffshelfDate { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Pop
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProPop", typeof(AllShowResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ProPop { get; set; }
    
    		    
    	}
    }
    
}
