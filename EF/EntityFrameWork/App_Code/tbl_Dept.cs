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
    
    public partial class tbl_Dept
    {
        public tbl_Dept()
        {
            this.tbl_Emp = new HashSet<tbl_Emp>();
        }
    
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptHOD { get; set; }
    
        public virtual ICollection<tbl_Emp> tbl_Emp { get; set; }
    }
}