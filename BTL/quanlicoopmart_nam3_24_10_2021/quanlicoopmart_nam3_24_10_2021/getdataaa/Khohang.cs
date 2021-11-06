namespace quanlicoopmart_nam3_24_10_2021.getdataaa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Khohang")]
    public partial class Khohang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khohang()
        {
            Phieunhaps = new HashSet<Phieunhap>();
            Phieuthongkes = new HashSet<Phieuthongke>();
        }

        [Key]
        [StringLength(20)]
        public string Mak { get; set; }

        [StringLength(50)]
        public string Tenk { get; set; }

        [StringLength(50)]
        public string Diadiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieunhap> Phieunhaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieuthongke> Phieuthongkes { get; set; }
    }
}
