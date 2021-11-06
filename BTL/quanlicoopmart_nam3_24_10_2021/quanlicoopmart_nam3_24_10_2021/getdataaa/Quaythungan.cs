namespace quanlicoopmart_nam3_24_10_2021.getdataaa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quaythungan")]
    public partial class Quaythungan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quaythungan()
        {
            Nhanviens = new HashSet<Nhanvien>();
        }

        [Key]
        [StringLength(20)]
        public string Maqtn { get; set; }

        [StringLength(40)]
        public string Tenqtn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
    }
}
