﻿using HamtaPharmaceutical.Domain.MedicineFeatures1;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamtaPharmaceutical.Domain.MedicineFeatures2;

public class MedicineFeature2
{
    public int ID { get; set; }
    public string PersianName { get; set; }
    public string EnglishName { get; set; }
    public string Code { get; set; }
    public bool IsActive { get; set; }
}

public class CustomerConfiguration : IEntityTypeConfiguration<MedicineFeature2>
{
    public void Configure(EntityTypeBuilder<MedicineFeature2> builder)
    {
        builder.HasKey(c => c.ID);
        builder.Property(c => c.PersianName).HasMaxLength(500);
        builder.Property(c => c.EnglishName).HasMaxLength(500);
        builder.Property(c => c.Code).HasMaxLength(20);
    }
}
