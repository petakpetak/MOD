//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicOnDemand
{
    using System;
    using System.Collections.Generic;
    
    public partial class album
    {
        public album()
        {
            this.pjesma = new HashSet<pjesma>();
        }
    
        public int albumID { get; set; }
        public int izvođačID { get; set; }
        public int žanrID { get; set; }
        public string nazivAlbuma { get; set; }
        public Nullable<short> godIzdanja { get; set; }
    
        public virtual izvođač izvođač { get; set; }
        public virtual žanr žanr { get; set; }
        public virtual žanr žanr1 { get; set; }
        public virtual ICollection<pjesma> pjesma { get; set; }
    }
}