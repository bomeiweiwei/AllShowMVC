//using slnMyStudy.Common;
//using slnMyStudy.Resource.App_GlobalResources;
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
    	    [DisplayName("EmpNo")]
            [Required(ErrorMessage = "Emp No is required")]
            [Key]
    		public int EmpNo { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Name
    		/// </summary>        
    	    [DisplayName("EmpName")]
            [Required(ErrorMessage = "Emp Name is required")]
            [MaxLength(20, ErrorMessage = "Emp Name cannot be longer than 20 characters")]
    		public string EmpName { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Account
    		/// </summary>        
    	    [DisplayName("EmpAccount")]
            [Required(ErrorMessage = "Emp Account is required")]
            [MaxLength(20, ErrorMessage = "Emp Account cannot be longer than 20 characters")]
    		public string EmpAccount { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Pwd
    		/// </summary>        
    	    [DisplayName("EmpPwd")]
            [Required(ErrorMessage = "Emp Pwd is required")]
            [MaxLength(20, ErrorMessage = "Emp Pwd cannot be longer than 20 characters")]
    		public string EmpPwd { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Email
    		/// </summary>        
    	    [DisplayName("EmpEmail")]
            [Required(ErrorMessage = "Emp Email is required")]
            [MaxLength(40, ErrorMessage = "Emp Email cannot be longer than 40 characters")]
    		public string EmpEmail { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Sex
    		/// </summary>        
    	    [DisplayName("EmpSex")]
            [Required(ErrorMessage = "Emp Sex is required")]
            [MaxLength(1, ErrorMessage = "Emp Sex cannot be longer than 1 characters")]
    		public string EmpSex { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Birth
    		/// </summary>        
    	    [DisplayName("EmpBirth")]
            [Required(ErrorMessage = "Emp Birth is required")]
    		public System.DateTime EmpBirth { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Tel
    		/// </summary>        
    	    [DisplayName("EmpTel")]
            [Required(ErrorMessage = "Emp Tel is required")]
            [MaxLength(10, ErrorMessage = "Emp Tel cannot be longer than 10 characters")]
    		public string EmpTel { get; set; }
    
    		    
    		/// <summary>
    		/// Hire Date
    		/// </summary>        
    	    [DisplayName("HireDate")]
            [Required(ErrorMessage = "Hire Date is required")]
    		public System.DateTime HireDate { get; set; }
    
    		    
    		/// <summary>
    		/// Leave Date
    		/// </summary>        
    	    [DisplayName("LeaveDate")]
    		public Nullable<System.DateTime> LeaveDate { get; set; }
    
    		    
    		/// <summary>
    		/// Emp Account State
    		/// </summary>        
    	    [DisplayName("EmpAccountState")]
            [MaxLength(1, ErrorMessage = "Emp Account State cannot be longer than 1 characters")]
    		public string EmpAccountState { get; set; }
    
    		    
    	}
    }
    
}
