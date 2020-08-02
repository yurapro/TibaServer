using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tiba.Domain;

namespace Tiba.Data.Configuration
{
    public class FavoritConfiguration : IEntityTypeConfiguration<Favorit>
    {
        public void Configure(EntityTypeBuilder<Favorit> builder)
        {
            builder.Property(b => b.Id).HasColumnName("Id");
        }
    }
}
