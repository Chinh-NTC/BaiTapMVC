using BT_C.Models;
using Microsoft.EntityFrameworkCore;

namespace BT_C.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<DangKy> DangKys { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DangKy>()
                .HasKey(dk => new { dk.SinhVienId, dk.KhoaHocId });
        }
    }
}
