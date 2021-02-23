using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
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
    	    [ResourceTool.LocalizedDisplayName("AdNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int AdNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShNo", typeof(AllShowResource))]
    		public Nullable<int> ShNo { get; set; }
    
    		    
    		/// <summary>
    		/// Emp No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmpNo", typeof(AllShowResource))]
    		public Nullable<int> EmpNo { get; set; }
    
    		    
    		/// <summary>
    		/// Ad Title
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("AdTitle", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string AdTitle { get; set; }
    
    		    
    		/// <summary>
    		/// Ad Apply Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("AdApplyDate", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public System.DateTime AdApplyDate { get; set; }
    
    		    
    		/// <summary>
    		/// Ad Start Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("AdStartDate", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public System.DateTime AdStartDate { get; set; }
    
    		    
    		/// <summary>
    		/// Ad Time
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("AdTime", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public System.DateTime AdTime { get; set; }
    
    		    
    		/// <summary>
    		/// Ad Price
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("AdPrice", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public int AdPrice { get; set; }
    
    		    
    		/// <summary>
    		/// Ad Pic
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("AdPic", typeof(AllShowResource))]
            [MaxLength(1000, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string AdPic { get; set; }
    
    		    
    		/// <summary>
    		/// Ad URL
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("AdURL", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string AdURL { get; set; }
    
    		    
    		/// <summary>
    		/// Ad Check State
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("AdCheckState", typeof(AllShowResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string AdCheckState { get; set; }
    
    		    
    	}
    }
    
}
