//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OgrenciMvcAsp.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblOgrenciler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblOgrenciler()
        {
            this.TblNotlar = new HashSet<TblNotlar>();
        }
    
        public int OGRID { get; set; }
        public string OGRAD { get; set; }
        public string OGRSOYAD { get; set; }
        public string OGRFOTO { get; set; }
        public string OGRCİNSİYET { get; set; }
        public Nullable<byte> OGRKULUP { get; set; }
    
        public virtual TblKulupler TblKulupler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblNotlar> TblNotlar { get; set; }
    }
}
