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
    
    public partial class Request
    {
        public int requestID { get; set; }
        public Nullable<int> sender_id { get; set; }
        public Nullable<int> reciever_id { get; set; }
        public Nullable<int> concernedUserID { get; set; }
        public Nullable<int> project_id { get; set; }
        public Nullable<bool> isApproved { get; set; }
        public Nullable<bool> Request_Status { get; set; }
    
        public virtual Projects Projects { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
        public virtual Users Users2 { get; set; }
    }
}
