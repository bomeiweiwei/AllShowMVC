//using slnMyStudy.Common;
//using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


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
    	    [DisplayName("ProNo")]
            [Required(ErrorMessage = "Pro No is required")]
            [Key]
    		public int ProNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh No
    		/// </summary>        
    	    [DisplayName("ShNo")]
    		public Nullable<int> ShNo { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Class No
    		/// </summary>        
    	    [DisplayName("ProClassNo")]
    		public Nullable<int> ProClassNo { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Name
    		/// </summary>        
    	    [DisplayName("ProName")]
            [Required(ErrorMessage = "Pro Name is required")]
            [MaxLength(20, ErrorMessage = "Pro Name cannot be longer than 20 characters")]
    		public string ProName { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Price
    		/// </summary>        
    	    [DisplayName("ProPrice")]
            [Required(ErrorMessage = "Pro Price is required")]
    		public int ProPrice { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Statement
    		/// </summary>        
    	    [DisplayName("ProStatement")]
            [MaxLength(200, ErrorMessage = "Pro Statement cannot be longer than 200 characters")]
    		public string ProStatement { get; set; }
    
    		    
    		/// <summary>
    		/// Pro State
    		/// </summary>        
    	    [DisplayName("ProState")]
            [MaxLength(1, ErrorMessage = "Pro State cannot be longer than 1 characters")]
    		public string ProState { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Pic1
    		/// </summary>        
    	    [DisplayName("ProPic1")]
            [MaxLength(1000, ErrorMessage = "Pro Pic1 cannot be longer than 1000 characters")]
    		public string ProPic1 { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Pic2
    		/// </summary>        
    	    [DisplayName("ProPic2")]
            [MaxLength(1000, ErrorMessage = "Pro Pic2 cannot be longer than 1000 characters")]
    		public string ProPic2 { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Pic3
    		/// </summary>        
    	    [DisplayName("ProPic3")]
            [MaxLength(1000, ErrorMessage = "Pro Pic3 cannot be longer than 1000 characters")]
    		public string ProPic3 { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Create Date
    		/// </summary>        
    	    [DisplayName("ProCreateDate")]
    		public Nullable<System.DateTime> ProCreateDate { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Update Date
    		/// </summary>        
    	    [DisplayName("ProUpdateDate")]
    		public Nullable<System.DateTime> ProUpdateDate { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Offshelf Date
    		/// </summary>        
    	    [DisplayName("ProOffshelfDate")]
    		public Nullable<System.DateTime> ProOffshelfDate { get; set; }
    
    		    
    		/// <summary>
    		/// Pro Pop
    		/// </summary>        
    	    [DisplayName("ProPop")]
            [MaxLength(1, ErrorMessage = "Pro Pop cannot be longer than 1 characters")]
    		public string ProPop { get; set; }
    
    		    
    	}
    }
    
}
