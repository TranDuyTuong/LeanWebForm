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
    
    public partial class StatusMusic
    {
        public StatusMusic()
        {
            this.Musics = new HashSet<Music>();
        }
    
        public int IdStatusMusic { get; set; }
        public string NameStatusMusic { get; set; }
        public System.DateTime DateCreate { get; set; }
    
        public virtual ICollection<Music> Musics { get; set; }
    }
}