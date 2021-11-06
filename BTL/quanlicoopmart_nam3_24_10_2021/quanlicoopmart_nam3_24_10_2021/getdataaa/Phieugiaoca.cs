namespace quanlicoopmart_nam3_24_10_2021.getdataaa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phieugiaoca")]
    public partial class Phieugiaoca
    {
        [Key]
        [StringLength(20)]
        public string Mapgc { get; set; }

        [StringLength(20)]
        public string Ca { get; set; }
    }
}
