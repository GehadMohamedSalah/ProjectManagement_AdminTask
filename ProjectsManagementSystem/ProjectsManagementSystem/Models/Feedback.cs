//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectsManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        public int id { get; set; }
        public string feedbackMessage { get; set; }
        public Nullable<int> TL_id { get; set; }
        public Nullable<int> PM_id { get; set; }
        public Nullable<bool> MessageIsRead { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
    }
}
