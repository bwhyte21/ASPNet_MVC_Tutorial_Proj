//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameWork.App_Code
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Emp
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
        public string EmpGender { get; set; }
        public System.DateTime EmpDOB { get; set; }
        public string EmailId { get; set; }
        public Nullable<int> DeptId { get; set; }
    
        public virtual tbl_Dept tbl_Dept { get; set; }
    }
}
