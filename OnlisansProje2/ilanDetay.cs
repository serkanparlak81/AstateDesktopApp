//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlisansProje2
{
    using System;
    using System.Collections.Generic;
    
    public partial class ilanDetay
    {
        public ilanDetay()
        {
            this.ilans = new HashSet<ilan>();
        }
    
        public int ilanID { get; set; }
        public string odaSayisi { get; set; }
        public Nullable<int> binaYasi { get; set; }
        public Nullable<int> katSayisi { get; set; }
        public Nullable<int> bulunduguKat { get; set; }
        public string isitma { get; set; }
        public string esyalimi { get; set; }
        public string aciklama { get; set; }
    
        public virtual ICollection<ilan> ilans { get; set; }
    }
}
