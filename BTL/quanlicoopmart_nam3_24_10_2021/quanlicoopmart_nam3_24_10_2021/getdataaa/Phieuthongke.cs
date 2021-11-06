namespace quanlicoopmart_nam3_24_10_2021.getdataaa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phieuthongke")]
    public partial class Phieuthongke
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phieuthongke()
        {
            Hanghoas = new HashSet<Hanghoa>();
        }

        [Key]
        [StringLength(20)]
        public string Maptk { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaylap { get; set; }

        [Required]
        [StringLength(20)]
        public string Manv { get; set; }

        [Required]
        [StringLength(20)]
        public string Mak { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hanghoa> Hanghoas { get; set; }

        public virtual Khohang Khohang { get; set; }

        public virtual Nhanvien Nhanvien { get; set; }
    }
}
