//using slnMyStudy.Common;
//using slnMyStudy.Resource.App_GlobalResources;
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
    	    [DisplayName("ShNo")]
            [Required(ErrorMessage = "Sh No is required")]
            [Key]
    		public int ShNo { get; set; }
    
    		    
    		/// <summary>
    		/// Emp No
    		/// </summary>        
    	    [DisplayName("EmpNo")]
    		public Nullable<int> EmpNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh The Pic
    		/// </summary>        
    	    [DisplayName("ShThePic")]
            [MaxLength(1000, ErrorMessage = "Sh The Pic cannot be longer than 1000 characters")]
    		public string ShThePic { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Name
    		/// </summary>        
    	    [DisplayName("ShName")]
            [Required(ErrorMessage = "Sh Name is required")]
            [MaxLength(20, ErrorMessage = "Sh Name cannot be longer than 20 characters")]
    		public string ShName { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Class No
    		/// </summary>        
    	    [DisplayName("ShClassNo")]
            [Required(ErrorMessage = "Sh Class No is required")]
            [MaxLength(10, ErrorMessage = "Sh Class No cannot be longer than 10 characters")]
    		public string ShClassNo { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Account
    		/// </summary>        
    	    [DisplayName("ShAccount")]
            [Required(ErrorMessage = "Sh Account is required")]
            [MaxLength(20, ErrorMessage = "Sh Account cannot be longer than 20 characters")]
    		public string ShAccount { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Pwd
    		/// </summary>        
    	    [DisplayName("ShPwd")]
            [Required(ErrorMessage = "Sh Pwd is required")]
            [MaxLength(20, ErrorMessage = "Sh Pwd cannot be longer than 20 characters")]
    		public string ShPwd { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Boss
    		/// </summary>        
    	    [DisplayName("ShBoss")]
            [Required(ErrorMessage = "Sh Boss is required")]
            [MaxLength(10, ErrorMessage = "Sh Boss cannot be longer than 10 characters")]
    		public string ShBoss { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Contact
    		/// </summary>        
    	    [DisplayName("ShContact")]
            [Required(ErrorMessage = "Sh Contact is required")]
            [MaxLength(10, ErrorMessage = "Sh Contact cannot be longer than 10 characters")]
    		public string ShContact { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Address
    		/// </summary>        
    	    [DisplayName("ShAddress")]
            [Required(ErrorMessage = "Sh Address is required")]
            [MaxLength(30, ErrorMessage = "Sh Address cannot be longer than 30 characters")]
    		public string ShAddress { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Tel
    		/// </summary>        
    	    [DisplayName("ShTel")]
            [Required(ErrorMessage = "Sh Tel is required")]
            [MaxLength(10, ErrorMessage = "Sh Tel cannot be longer than 10 characters")]
    		public string ShTel { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Email
    		/// </summary>        
    	    [DisplayName("ShEmail")]
            [Required(ErrorMessage = "Sh Email is required")]
            [MaxLength(30, ErrorMessage = "Sh Email cannot be longer than 30 characters")]
    		public string ShEmail { get; set; }
    
    		    
    		/// <summary>
    		/// Sh About
    		/// </summary>        
    	    [DisplayName("ShAbout")]
            [MaxLength(300, ErrorMessage = "Sh About cannot be longer than 300 characters")]
    		public string ShAbout { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Logo Pic
    		/// </summary>        
    	    [DisplayName("ShLogoPic")]
            [MaxLength(1000, ErrorMessage = "Sh Logo Pic cannot be longer than 1000 characters")]
    		public string ShLogoPic { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Url
    		/// </summary>        
    	    [DisplayName("ShUrl")]
            [Required(ErrorMessage = "Sh Url is required")]
            [MaxLength(50, ErrorMessage = "Sh Url cannot be longer than 50 characters")]
    		public string ShUrl { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Ad State
    		/// </summary>        
    	    [DisplayName("ShAdState")]
            [MaxLength(1, ErrorMessage = "Sh Ad State cannot be longer than 1 characters")]
    		public string ShAdState { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Ad Title
    		/// </summary>        
    	    [DisplayName("ShAdTitle")]
            [MaxLength(20, ErrorMessage = "Sh Ad Title cannot be longer than 20 characters")]
    		public string ShAdTitle { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Ad Pic
    		/// </summary>        
    	    [DisplayName("ShAdPic")]
            [MaxLength(1000, ErrorMessage = "Sh Ad Pic cannot be longer than 1000 characters")]
    		public string ShAdPic { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Pop Shop
    		/// </summary>        
    	    [DisplayName("ShPopShop")]
            [MaxLength(1, ErrorMessage = "Sh Pop Shop cannot be longer than 1 characters")]
    		public string ShPopShop { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Check State
    		/// </summary>        
    	    [DisplayName("ShCheckState")]
            [MaxLength(1, ErrorMessage = "Sh Check State cannot be longer than 1 characters")]
    		public string ShCheckState { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Start Date
    		/// </summary>        
    	    [DisplayName("ShStartDate")]
    		public Nullable<System.DateTime> ShStartDate { get; set; }
    
    		    
    		/// <summary>
    		/// Sh End Date
    		/// </summary>        
    	    [DisplayName("ShEndDate")]
    		public Nullable<System.DateTime> ShEndDate { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Check Date
    		/// </summary>        
    	    [DisplayName("ShCheckDate")]
    		public Nullable<System.DateTime> ShCheckDate { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Pwd State
    		/// </summary>        
    	    [DisplayName("ShPwdState")]
            [MaxLength(1, ErrorMessage = "Sh Pwd State cannot be longer than 1 characters")]
    		public string ShPwdState { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Stop Right Start Date
    		/// </summary>        
    	    [DisplayName("ShStopRightStartDate")]
    		public Nullable<System.DateTime> ShStopRightStartDate { get; set; }
    
    		    
    		/// <summary>
    		/// Sh Stop Right Enddate
    		/// </summary>        
    	    [DisplayName("ShStopRightEnddate")]
    		public Nullable<System.DateTime> ShStopRightEnddate { get; set; }
    
    		    
    	}
    }
    
}
