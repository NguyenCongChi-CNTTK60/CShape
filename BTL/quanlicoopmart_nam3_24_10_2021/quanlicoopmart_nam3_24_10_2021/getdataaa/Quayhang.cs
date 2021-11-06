namespace quanlicoopmart_nam3_24_10_2021.getdataaa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quayhang")]
    public partial class Quayhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quayhang()
        {
            Hanghoas = new HashSet<Hanghoa>();
        }

        [Key]
        [StringLength(20)]
        public string Maqh { get; set; }

        [StringLength(50)]
        public string Tenqh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hanghoa> Hanghoas { get; set; }
    }
}
