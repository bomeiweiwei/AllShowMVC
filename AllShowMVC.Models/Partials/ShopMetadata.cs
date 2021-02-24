using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// Shop class
    /// </summary>
    [MetadataType(typeof(ShopMD))]
    public partial class Shop
    {
    
    	/// <summary>
    	/// Shop Metadata class
    	/// </summary>
    	public class ShopMD
    	{
    		    
    		/// <summary>
    		/// Sh No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int ShNo { get; set; }
    
    		    
    		/// <summary>
    		/// Emp No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmpNo", typeof(AllShowResource))]
    		public Nullable<int> EmpNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh The Pic
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShThePic", typeof(AllShowResource))]
            [MaxLength(1000, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShThePic { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShName", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShName { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Class No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShClassNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShClassNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Account
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShAccount", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShAccount { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Pwd
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShPwd", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShPwd { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Boss
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShBoss", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShBoss { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Contact
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShContact", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShContact { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Address
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShAddress", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(30, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShAddress { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Tel
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShTel", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShTel { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Email
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShEmail", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(256, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShEmail { get; set; }
    
    		    
    		/// <summary>
    		/// Sh About
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShAbout", typeof(AllShowResource))]
            [MaxLength(300, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShAbout { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Logo Pic
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShLogoPic", typeof(AllShowResource))]
            [MaxLength(1000, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShLogoPic { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Url
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShUrl", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShUrl { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Ad State
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShAdState", typeof(AllShowResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShAdState { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Ad Title
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShAdTitle", typeof(AllShowResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShAdTitle { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Ad Pic
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShAdPic", typeof(AllShowResource))]
            [MaxLength(1000, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShAdPic { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Pop Shop
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShPopShop", typeof(AllShowResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShPopShop { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Check State
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShCheckState", typeof(AllShowResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShCheckState { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Start Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShStartDate", typeof(AllShowResource))]
    		public Nullable<System.DateTime> ShStartDate { get; set; }
    
    		    
    		/// <summary>
    		/// Sh End Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShEndDate", typeof(AllShowResource))]
    		public Nullable<System.DateTime> ShEndDate { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Check Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShCheckDate", typeof(AllShowResource))]
    		public Nullable<System.DateTime> ShCheckDate { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Pwd State
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShPwdState", typeof(AllShowResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string ShPwdState { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Stop Right Start Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShStopRightStartDate", typeof(AllShowResource))]
    		public Nullable<System.DateTime> ShStopRightStartDate { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Stop Right Enddate
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShStopRightEnddate", typeof(AllShowResource))]
    		public Nullable<System.DateTime> ShStopRightEnddate { get; set; }
    
    		    
    	}
    }
    
}
