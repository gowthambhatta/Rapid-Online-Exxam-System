//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace onllineexam.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Result
    {
        public int ResId { get; set; }
        public Nullable<int> Stu_id { get; set; }
        public string sub_id { get; set; }
        public Nullable<int> testid { get; set; }
        public string score1 { get; set; }
        public string score2 { get; set; }
        public string score3 { get; set; }
        public string Status { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual TestGenerator TestGenerator { get; set; }
    }
}
