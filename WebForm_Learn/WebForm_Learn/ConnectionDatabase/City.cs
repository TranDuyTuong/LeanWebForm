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
    
    public partial class City
    {
        public City()
        {
            this.Districts = new HashSet<District>();
            this.Users = new HashSet<User>();
        }
    
        public int IdCity { get; set; }
        public string NameCity { get; set; }
        public System.DateTime DateCreate { get; set; }
    
        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}