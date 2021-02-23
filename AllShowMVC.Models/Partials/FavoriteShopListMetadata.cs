using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// FavoriteShopList class
    /// </summary>
    [MetadataType(typeof(FavoriteShopListMD))]
    public partial class FavoriteShopList
    {
    
    	/// <summary>
    	/// FavoriteShopList Metadata class
    	/// </summary>
    	public class FavoriteShopListMD
    	{
    		    
    		/// <summary>
    		/// Mem No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("MemNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int MemNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int ShNo { get; set; }
    
    		    
    		/// <summary>
    		/// Note
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Note", typeof(AllShowResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string Note { get; set; }
    
    		    
    	}
    }
    
}
