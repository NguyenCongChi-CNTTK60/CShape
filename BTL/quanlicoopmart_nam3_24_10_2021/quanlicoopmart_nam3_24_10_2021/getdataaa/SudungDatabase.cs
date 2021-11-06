using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace quanlicoopmart_nam3_24_10_2021.getdataaa
{
    public partial class SudungDatabase : DbContext
    {
        public SudungDatabase()
            : base("name=SudungDatabase")
        {
        }

        public virtual DbSet<Chucvu> Chucvus { get; set; }
        public virtual DbSet<Hanghoa> Hanghoas { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Khohang> Khohangs { get; set; }
        public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Phieugiaoca> Phieugiaocas { get; set; }
        public virtual DbSet<Phieunhap> Phieunhaps { get; set; }
        public virtual DbSet<Phieuthongke> Phieuthongkes { get; set; }
        public virtual DbSet<Quayhang> Quayhangs { get; set; }
        public virtual DbSet<Quaythungan> Quaythungans { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Chitiethd> Chitiethds { get; set; }
        public virtual DbSet<Chitietpn> Chitietpns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chucvu>()
                .HasMany(e => e.Nhanviens)
                .WithOptional(e => e.Chucvu)
                .HasForeignKey(e => e.Macv);

            modelBuilder.Entity<Chucvu>()
                .HasMany(e => e.Nhanviens1)
                .WithOptional(e => e.Chucvu1)
                .HasForeignKey(e => e.Macv);

            modelBuilder.Entity<Hanghoa>()
                .HasMany(e => e.Chitiethds)
                .WithRequired(e => e.Hanghoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hanghoa>()
                .HasMany(e => e.Chitietpns)
                .WithRequired(e => e.Hanghoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hoadon>()
                .HasMany(e => e.Chitiethds)
                .WithRequired(e => e.Hoadon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khohang>()
                .HasMany(e => e.Phieunhaps)
                .WithRequired(e => e.Khohang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khohang>()
                .HasMany(e => e.Phieuthongkes)
                .WithRequired(e => e.Khohang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nhacungcap>()
                .HasMany(e => e.Phieunhaps)
                .WithRequired(e => e.Nhacungcap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nhanvien>()
                .HasMany(e => e.Phieuthongkes)
                .WithRequired(e => e.Nhanvien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phieunhap>()
                .HasMany(e => e.Chitietpns)
                .WithRequired(e => e.Phieunhap)
                .WillCascadeOnDelete(false);
        }
    }
}
