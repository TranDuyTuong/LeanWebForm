//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForm_Learn.ConnectionDatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeleteNotification
    {
        public DeleteNotification()
        {
            this.NotificationUsers = new HashSet<NotificationUser>();
        }
    
        public int IdDeleteNotification { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreate { get; set; }
    
        public virtual ICollection<NotificationUser> NotificationUsers { get; set; }
    }
}
