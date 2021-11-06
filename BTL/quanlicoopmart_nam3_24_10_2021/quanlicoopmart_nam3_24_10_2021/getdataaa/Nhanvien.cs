namespace quanlicoopmart_nam3_24_10_2021.getdataaa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nhanvien")]
    public partial class Nhanvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nhanvien()
        {
            Hoadons = new HashSet<Hoadon>();
            Phieuthongkes = new HashSet<Phieuthongke>();
        }

        [Key]
        [StringLength(20)]
        public string Manv { get; set; }

        [StringLength(50)]
        public string Tennv { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaysinh { get; set; }

        [StringLength(10)]
        public string Gioitinh { get; set; }

        [StringLength(50)]
        public string Diachi { get; set; }

        [StringLength(15)]
        public string Sdt { get; set; }

        [StringLength(40)]
        public string Tendangnhap { get; set; }

        [StringLength(40)]
        public string Matkhau { get; set; }

        [StringLength(20)]
        public string Macv { get; set; }

        [StringLength(20)]
        public string Maqtn { get; set; }

        public virtual Chucvu Chucvu { get; set; }

        public virtual Chucvu Chucvu1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hoadon> Hoadons { get; set; }

        public virtual Quaythungan Quaythungan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieuthongke> Phieuthongkes { get; set; }
    }
}
