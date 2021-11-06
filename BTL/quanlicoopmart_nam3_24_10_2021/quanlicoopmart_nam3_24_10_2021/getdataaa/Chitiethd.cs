namespace quanlicoopmart_nam3_24_10_2021.getdataaa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chitiethd")]
    public partial class Chitiethd
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Mahd { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Mahh { get; set; }

        public int? Dongia { get; set; }

        public int? Soluong { get; set; }

        public virtual Hanghoa Hanghoa { get; set; }

        public virtual Hoadon Hoadon { get; set; }
    }
}
