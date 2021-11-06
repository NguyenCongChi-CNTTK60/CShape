namespace quanlicoopmart_nam3_24_10_2021.getdataaa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chitietpn")]
    public partial class Chitietpn
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Mapn { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Mahh { get; set; }

        public double? Dongia { get; set; }

        public int? Soluong { get; set; }

        public virtual Hanghoa Hanghoa { get; set; }

        public virtual Phieunhap Phieunhap { get; set; }
    }
}
