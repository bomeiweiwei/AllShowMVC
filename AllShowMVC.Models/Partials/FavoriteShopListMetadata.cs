//using slnMyStudy.Common;
//using slnMyStudy.Resource.App_GlobalResources;
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
    	    [DisplayName("MemNo")]
            [Required(ErrorMessage = "Mem No is required")]
            [Key]
    		public int MemNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh No
    		/// </summary>        
    	    [DisplayName("ShNo")]
            [Required(ErrorMessage = "Sh No is required")]
            [Key]
    		public int ShNo { get; set; }
    
    		    
    		/// <summary>
    		/// Note
    		/// </summary>        
    	    [DisplayName("Note")]
            [MaxLength(10, ErrorMessage = "Note cannot be longer than 10 characters")]
    		public string Note { get; set; }
    
    		    
    	}
    }
    
}
