//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class BireyselUnvan
    {
        public BireyselUnvan()
        {
            this.MusteriBireysels = new HashSet<MusteriBireysel>();
        }
    
        public int UnvanID { get; set; }
        public string Unvan { get; set; }
    
        public virtual ICollection<MusteriBireysel> MusteriBireysels { get; set; }
    }
}
