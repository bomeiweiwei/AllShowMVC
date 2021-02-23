//using slnMyStudy.Common;
//using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


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
    	    [DisplayName("AnnouncementNo")]
            [Required(ErrorMessage = "Announcement No is required")]
            [Key]
    		public int AnnouncementNo { get; set; }
    
    		    
    		/// <summary>
    		/// Emp No
    		/// </summary>        
    	    [DisplayName("EmpNo")]
    		public Nullable<int> EmpNo { get; set; }
    
    		    
    		/// <summary>
    		/// Announcement Type
    		/// </summary>        
    	    [DisplayName("AnnouncementType")]
            [Required(ErrorMessage = "Announcement Type is required")]
            [MaxLength(20, ErrorMessage = "Announcement Type cannot be longer than 20 characters")]
    		public string AnnouncementType { get; set; }
    
    		    
    		/// <summary>
    		/// Announcement Content
    		/// </summary>        
    	    [DisplayName("AnnouncementContent")]
            [Required(ErrorMessage = "Announcement Content is required")]
            [MaxLength(300, ErrorMessage = "Announcement Content cannot be longer than 300 characters")]
    		public string AnnouncementContent { get; set; }
    
    		    
    		/// <summary>
    		/// Create Date
    		/// </summary>        
    	    [DisplayName("CreateDate")]
            [Required(ErrorMessage = "Create Date is required")]
    		public System.DateTime CreateDate { get; set; }
    
    		    
    		/// <summary>
    		/// Update Date
    		/// </summary>        
    	    [DisplayName("UpdateDate")]
    		public Nullable<System.DateTime> UpdateDate { get; set; }
    
    		    
    		/// <summary>
    		/// Start Date
    		/// </summary>        
    	    [DisplayName("StartDate")]
            [Required(ErrorMessage = "Start Date is required")]
    		public System.DateTime StartDate { get; set; }
    
    		    
    		/// <summary>
    		/// End Date
    		/// </summary>        
    	    [DisplayName("EndDate")]
            [Required(ErrorMessage = "End Date is required")]
    		public System.DateTime EndDate { get; set; }
    
    		    
    	}
    }
    
}
