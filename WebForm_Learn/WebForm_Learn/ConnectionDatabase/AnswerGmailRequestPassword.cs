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
    
    public partial class AnswerGmailRequestPassword
    {
        public int IdAnswerGmail { get; set; }
        public int IdRequestPassword { get; set; }
        public string IdStaff { get; set; }
        public Nullable<System.Guid> IdUser { get; set; }
        public string NameUser { get; set; }
        public string TitleAnswer { get; set; }
        public string ContentAnswer { get; set; }
        public System.DateTime DateAnswer { get; set; }
    
        public virtual RequestPassword RequestPassword { get; set; }
    }
}
