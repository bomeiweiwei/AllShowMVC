//using slnMyStudy.Common;
//using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// Advertisement class
    /// </summary>
    [MetadataType(typeof(AdvertisementMD))]
    public partial class Advertisement
    {
    
    	/// <summary>
    	/// Advertisement Metadata class
    	/// </summary>
    	public class AdvertisementMD
    	{
    		    
    		/// <summary>
    		/// Ad No
    		/// </summary>        
    	    [DisplayName("AdNo")]
            [Required(ErrorMessage = "Ad No is required")]
            [Key]
    		public int AdNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh No
    		/// </summary>        
    	    [DisplayName("ShNo")]
    		public Nullable<int> ShNo { get; set; }
    
    		    
    		/// <summary>
    		/// Emp No
    		/// </summary>        
    	    [DisplayName("EmpNo")]
    		public Nullable<int> EmpNo { get; set; }
    
    		    
    		/// <summary>
    		/// Ad Title
    		/// </summary>        
    	    [DisplayName("AdTitle")]
            [Required(ErrorMessage = "Ad Title is required")]
            [MaxLength(20, ErrorMessage = "Ad Title cannot be longer than 20 characters")]
    		public string AdTitle { get; set; }
    
    		    
    		/// <summary>
    		/// Ad Apply Date
    		/// </summary>        
    	    [DisplayName("AdApplyDate")]
            [Required(ErrorMessage = "Ad Apply Date is required")]
    		public System.DateTime AdApplyDate { get; set; }
    
    		    
    		/// <summary>
    		/// Ad Start Date
    		/// </summary>        
    	    [DisplayName("AdStartDate")]
            [Required(ErrorMessage = "Ad Start Date is required")]
    		public System.DateTime AdStartDate { get; set; }
    
    		    
    		/// <summary>
    		/// Ad Time
    		/// </summary>        
    	    [DisplayName("AdTime")]
            [Required(ErrorMessage = "Ad Time is required")]
    		public System.DateTime AdTime { get; set; }
    
    		    
    		/// <summary>
    		/// Ad Price
    		/// </summary>        
    	    [DisplayName("AdPrice")]
            [Required(ErrorMessage = "Ad Price is required")]
    		public int AdPrice { get; set; }
    
    		    
    		/// <summary>
    		/// Ad Pic
    		/// </summary>        
    	    [DisplayName("AdPic")]
            [MaxLength(1000, ErrorMessage = "Ad Pic cannot be longer than 1000 characters")]
    		public string AdPic { get; set; }
    
    		    
    		/// <summary>
    		/// Ad URL
    		/// </summary>        
    	    [DisplayName("AdURL")]
            [Required(ErrorMessage = "Ad URL is required")]
            [MaxLength(20, ErrorMessage = "Ad URL cannot be longer than 20 characters")]
    		public string AdURL { get; set; }
    
    		    
    		/// <summary>
    		/// Ad Check State
    		/// </summary>        
    	    [DisplayName("AdCheckState")]
            [MaxLength(10, ErrorMessage = "Ad Check State cannot be longer than 10 characters")]
    		public string AdCheckState { get; set; }
    
    		    
    	}
    }
    
}
