using HamtaPharmaceutical.Domain.MedicineCategories;
using HamtaPharmaceutical.Domain.MedicineCentimeters;
using HamtaPharmaceutical.Domain.MedicineColors;
using HamtaPharmaceutical.Domain.MedicineDiameters;
using HamtaPharmaceutical.Domain.MedicineFeatures1;
using HamtaPharmaceutical.Domain.MedicineFeatures2;
using HamtaPharmaceutical.Domain.MedicineLists;
using HamtaPharmaceutical.Domain.MedicineMaterials;
using HamtaPharmaceutical.Domain.MedicineModels;
using HamtaPharmaceutical.Domain.MedicineSizes;
using Microsoft.EntityFrameworkCore;

namespace HamtaPharmaceutical.Infrastructure.Data;

public class HamtaDbContext : DbContext
{
    public HamtaDbContext(DbContextOptions<HamtaDbContext> options)
       : base(options)
    {

    }

    public DbSet<MedicineCategory> MedicineCategories { get; set; }
    public DbSet<MedicineCentimeter> MedicineCentimeters { get; set; }
    public DbSet<MedicineColor> MedicineColors { get; set; }
    public DbSet<MedicineDiameter> MedicineDiameters { get; set; }
    public DbSet<MedicineFeature1> MedicineFeature1s { get; set; }
    public DbSet<MedicineFeature2> MedicineFeature2s { get; set; }
    public DbSet<MedicineList> MedicineLists { get; set; }
    public DbSet<MedicineMaterial> MedicineMaterials { get; set; }
    public DbSet<MedicineModel> MedicineModels { get; set; }
    public DbSet<MedicineSize> MedicineSizes { get; set; }
}
