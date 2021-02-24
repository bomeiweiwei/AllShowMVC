using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AllShowMVC.Models
{
    
    /// <summary>
    /// Employee class
    /// </summary>
    [MetadataType(typeof(EmployeeMD))]
    public partial class Employee
    {
    
    	/// <summary>
    	/// Employee Metadata class
    	/// </summary>
    	public class EmployeeMD
    	{
    		    
    		/// <summary>
    		/// Emp No
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmpNo", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [Key]
    		public int EmpNo { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmpName", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string EmpName { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Account
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmpAccount", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string EmpAccount { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Pwd
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmpPwd", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string EmpPwd { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Email
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmpEmail", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(256, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string EmpEmail { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Sex
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmpSex", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string EmpSex { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Birth
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmpBirth", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public System.DateTime EmpBirth { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Tel
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmpTel", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string EmpTel { get; set; }
    
    		    
    		/// <summary>
    		/// Hire Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("HireDate", typeof(AllShowResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
    		public System.DateTime HireDate { get; set; }
    
    		    
    		/// <summary>
    		/// Leave Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("LeaveDate", typeof(AllShowResource))]
    		public Nullable<System.DateTime> LeaveDate { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Account State
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmpAccountState", typeof(AllShowResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
    		public string EmpAccountState { get; set; }
    
    		    
    	}
    }
    
}
