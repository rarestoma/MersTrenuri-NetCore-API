using DAW.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAW.Domain.EF.ModelConfigurations
{
    public class TrainEntityConfiguration : IEntityTypeConfiguration<Train>
    {
        public void Configure(EntityTypeBuilder<Train> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Id);
        }
    }
}
