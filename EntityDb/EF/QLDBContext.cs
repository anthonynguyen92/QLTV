using EntityDb.Configuration;
using EntityDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDb.EF
{
    public class QLDBContext : DbContext
    {
        
        public QLDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BangCap> BangCap{ get; set; }
        public DbSet<DocGia> DocGia { get; set; }
        public DbSet<PhieuMuonSach> PhieuMuonSach { get; set; }
        public DbSet<PhieuThuTien> PhieuThuTien { get; set; }
        public DbSet<Sach> Sach { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BangCapConfiguration());
            modelBuilder.ApplyConfiguration(new DocGiaConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuMuonSachConfiguration());
            modelBuilder.ApplyConfiguration(new SachConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuThuTienConfiguration());

        }

    }
}
