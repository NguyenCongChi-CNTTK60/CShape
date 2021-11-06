namespace quanlicoopmart_nam3_24_10_2021.getdataaa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phieunhap")]
    public partial class Phieunhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phieunhap()
        {
            Chitietpns = new HashSet<Chitietpn>();
        }

        [Key]
        [StringLength(20)]
        public string Mapn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaynhap { get; set; }

        [Required]
        [StringLength(20)]
        public string Mancc { get; set; }

        [Required]
        [StringLength(20)]
        public string Mak { get; set; }

        public virtual Khohang Khohang { get; set; }

        public virtual Nhacungcap Nhacungcap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietpn> Chitietpns { get; set; }
    }
}
