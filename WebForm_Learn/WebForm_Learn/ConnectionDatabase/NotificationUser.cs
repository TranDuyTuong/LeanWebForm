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
    
    public partial class NotificationUser
    {
        public int IdNotification { get; set; }
        public System.Guid IdUser { get; set; }
        public int IdViewNotification { get; set; }
        public int IdDeleteNotification { get; set; }
        public string TitleNotification { get; set; }
        public System.DateTime DateCreate { get; set; }
        public System.DateTime TimeCreate { get; set; }
        public string AuthorNotification { get; set; }
    
        public virtual DeleteNotification DeleteNotification { get; set; }
        public virtual User User { get; set; }
        public virtual ViewNotification ViewNotification { get; set; }
    }
}