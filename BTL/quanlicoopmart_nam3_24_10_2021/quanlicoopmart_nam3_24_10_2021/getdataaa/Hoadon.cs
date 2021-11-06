namespace quanlicoopmart_nam3_24_10_2021.getdataaa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hoadon")]
    public partial class Hoadon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hoadon()
        {
            Chitiethds = new HashSet<Chitiethd>();
        }

        [Key]
        [StringLength(20)]
        public string Mahd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaytao { get; set; }

        public double? Tongtien { get; set; }

        [StringLength(20)]
        public string Manv { get; set; }

        [StringLength(20)]
        public string Makh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitiethd> Chitiethds { get; set; }

        public virtual Khachhang Khachhang { get; set; }

        public virtual Nhanvien Nhanvien { get; set; }
    }
}
