//using slnMyStudy.Common;
//using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// Member class
    /// </summary>
    [MetadataType(typeof(MemberMD))]
    public partial class Member
    {
    
    	/// <summary>
    	/// Member Metadata class
    	/// </summary>
    	public class MemberMD
    	{
    		    
    		/// <summary>
    		/// Mem No
    		/// </summary>        
    	    [DisplayName("MemNo")]
            [Required(ErrorMessage = "Mem No is required")]
            [Key]
    		public int MemNo { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Email
    		/// </summary>        
    	    [DisplayName("MemEmail")]
            [Required(ErrorMessage = "Mem Email is required")]
            [MaxLength(60, ErrorMessage = "Mem Email cannot be longer than 60 characters")]
    		public string MemEmail { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Pwd
    		/// </summary>        
    	    [DisplayName("MemPwd")]
            [Required(ErrorMessage = "Mem Pwd is required")]
            [MaxLength(20, ErrorMessage = "Mem Pwd cannot be longer than 20 characters")]
    		public string MemPwd { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Diminutive
    		/// </summary>        
    	    [DisplayName("MemDiminutive")]
            [MaxLength(40, ErrorMessage = "Mem Diminutive cannot be longer than 40 characters")]
    		public string MemDiminutive { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Name
    		/// </summary>        
    	    [DisplayName("MemName")]
            [Required(ErrorMessage = "Mem Name is required")]
            [MaxLength(40, ErrorMessage = "Mem Name cannot be longer than 40 characters")]
    		public string MemName { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Sex
    		/// </summary>        
    	    [DisplayName("MemSex")]
            [Required(ErrorMessage = "Mem Sex is required")]
            [MaxLength(1, ErrorMessage = "Mem Sex cannot be longer than 1 characters")]
    		public string MemSex { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Tel
    		/// </summary>        
    	    [DisplayName("MemTel")]
            [Required(ErrorMessage = "Mem Tel is required")]
            [MaxLength(10, ErrorMessage = "Mem Tel cannot be longer than 10 characters")]
    		public string MemTel { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Address
    		/// </summary>        
    	    [DisplayName("MemAddress")]
            [Required(ErrorMessage = "Mem Address is required")]
            [MaxLength(80, ErrorMessage = "Mem Address cannot be longer than 80 characters")]
    		public string MemAddress { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Pic
    		/// </summary>        
    	    [DisplayName("MemPic")]
            [MaxLength(1000, ErrorMessage = "Mem Pic cannot be longer than 1000 characters")]
    		public string MemPic { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Account State
    		/// </summary>        
    	    [DisplayName("MemAccountState")]
            [MaxLength(1, ErrorMessage = "Mem Account State cannot be longer than 1 characters")]
    		public string MemAccountState { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Check Number
    		/// </summary>        
    	    [DisplayName("MemCheckNumber")]
            [Required(ErrorMessage = "Mem Check Number is required")]
            [MaxLength(5, ErrorMessage = "Mem Check Number cannot be longer than 5 characters")]
    		public string MemCheckNumber { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Create Date
    		/// </summary>        
    	    [DisplayName("MemCreateDate")]
            [Required(ErrorMessage = "Mem Create Date is required")]
    		public System.DateTime MemCreateDate { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Uudate Date
    		/// </summary>        
    	    [DisplayName("MemUudateDate")]
    		public Nullable<System.DateTime> MemUudateDate { get; set; }
    
    		    
    		/// <summary>
    		/// Mem Birth
    		/// </summary>        
    	    [DisplayName("MemBirth")]
    		public Nullable<System.DateTime> MemBirth { get; set; }
    
    		    
    	}
    }
    
}
