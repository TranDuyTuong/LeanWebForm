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
    
    public partial class ChatImageStaff
    {
        public int Id { get; set; }
        public string NameImage { get; set; }
        public string TypeImage { get; set; }
        public byte[] FileImage { get; set; }
        public int IdChat { get; set; }
        public System.DateTime DateCreate { get; set; }
        public string MimeType { get; set; }
        public string ImageBase64 { get; set; }
    }
}
