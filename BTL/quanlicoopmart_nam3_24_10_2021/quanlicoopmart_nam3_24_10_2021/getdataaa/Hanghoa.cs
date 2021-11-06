namespace quanlicoopmart_nam3_24_10_2021.getdataaa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("Hanghoa")]
    public partial class Hanghoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hanghoa()
        {
            Chitiethds = new HashSet<Chitiethd>();
            Chitietpns = new HashSet<Chitietpn>();
        }

        [Key]
        [StringLength(20)]
        public string Mahh { get; set; }

        [StringLength(50)]
        public string Tenhh { get; set; }

        [StringLength(50)]
        public string Loai { get; set; }

        public int? Dongia { get; set; }

        [StringLength(20)]
        public string ĐVT { get; set; }

        public int? Soluong { get; set; }

        [StringLength(20)]
        public string Maqh { get; set; }

        [StringLength(20)]
        public string Maptk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitiethd> Chitiethds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietpn> Chitietpns { get; set; }

        public virtual Phieuthongke Phieuthongke { get; set; }

        public virtual Quayhang Quayhang { get; set; }


        public Hanghoa(DataRow row)
        {
            this.Mahh = row["Mahh"].ToString();
            this.Tenhh = row["Tenhh"].ToString();
            this.Loai = row["Loai"].ToString();
            this.Dongia = (int)row["Dongia"];
            this.ĐVT = row["ĐVT"].ToString();
            this.Soluong = (int)row["Soluong"];
            this.Maqh = row["Maqh"].ToString();
            this.Maptk = row["Maptk"].ToString();
        }
    }
}
