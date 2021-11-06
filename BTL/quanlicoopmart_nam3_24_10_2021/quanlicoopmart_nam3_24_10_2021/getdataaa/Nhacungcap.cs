namespace quanlicoopmart_nam3_24_10_2021.getdataaa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nhacungcap")]
    public partial class Nhacungcap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nhacungcap()
        {
            Phieunhaps = new HashSet<Phieunhap>();
        }

        [Key]
        [StringLength(20)]
        public string Mancc { get; set; }

        [StringLength(50)]
        public string Tenncc { get; set; }

        [StringLength(60)]
        public string Diadiem { get; set; }

        [StringLength(15)]
        public string SĐT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieunhap> Phieunhaps { get; set; }
    }
}
