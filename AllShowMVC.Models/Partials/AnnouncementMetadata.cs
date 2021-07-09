using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// Announcement class
    /// </summary>
    [MetadataType(typeof(AnnouncementMD))]
    public partial class Announcement
    {
    
    	/// <summary>
    	/// Announcement Metadata class
    	/// </summary>
    	public class AnnouncementMD
    	{
    		    
    		/// <summary>
    		/// Announcement No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("AnnouncementNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int AnnouncementNo { get; set; }
    
    		    
    		/// <summary>
    		/// Emp No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmpNo", typeof(AllShowResource))]
    		public Nullable<int> EmpNo { get; set; }
    
    		    
    		/// <summary>
    		/// Announcement Type
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("AnnouncementType", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string AnnouncementType { get; set; }
    
    		    
    		/// <summary>
    		/// Announcement Content
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("AnnouncementContent", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(300, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string AnnouncementContent { get; set; }
    
    		    
    		/// <summary>
    		/// Create Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CreateDate", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public System.DateTime CreateDate { get; set; }
    
    		    
    		/// <summary>
    		/// Update Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("UpdateDate", typeof(AllShowResource))]
    		public Nullable<System.DateTime> UpdateDate { get; set; }
    
    		    
    		/// <summary>
    		/// Start Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("StartDate", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public System.DateTime StartDate { get; set; }
    
    		    
    		/// <summary>
    		/// End Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EndDate", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public System.DateTime EndDate { get; set; }
    
    		    
    	}
    }
    
}
