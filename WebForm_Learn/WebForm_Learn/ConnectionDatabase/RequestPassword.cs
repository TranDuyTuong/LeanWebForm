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
    
    public partial class RequestPassword
    {
        public RequestPassword()
        {
            this.AnswerGmailRequestPasswords = new HashSet<AnswerGmailRequestPassword>();
        }
    
        public int IdRequestPassword { get; set; }
        public int IdReceiveRequest { get; set; }
        public Nullable<System.Guid> IdUser { get; set; }
        public string NameUser { get; set; }
        public string TitleRequest { get; set; }
        public string ContentRequest { get; set; }
        public string GmailRequest { get; set; }
        public byte[] ImageRequest { get; set; }
        public System.DateTime DateRequest { get; set; }
        public Nullable<System.DateTime> DateHandled { get; set; }
        public Nullable<System.DateTime> DateSuccess { get; set; }
        public string MineType { get; set; }
        public string TypeImg { get; set; }
    
        public virtual ICollection<AnswerGmailRequestPassword> AnswerGmailRequestPasswords { get; set; }
        public virtual ReceiveRequest ReceiveRequest { get; set; }
    }
}