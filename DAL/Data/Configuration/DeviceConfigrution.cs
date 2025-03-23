using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Configuration
{
    public class DeviceConfigrution : IEntityTypeConfiguration<Devices>
    {
        public void Configure(EntityTypeBuilder<Devices> builder)
        {
            builder.HasData(
                new Devices { Id = 1, Name = "PlayStation", Icon = "bi bi-playstation" },
                new Devices { Id = 2, Name = "Xbox", Icon = "bi bi-xbox" },
                new Devices { Id = 3, Name = "PC", Icon = "bi bi-pc-display" },
                new Devices { Id = 4, Name = "Nintendo Switch", Icon = "bi bi-nintendo-switch" }
            );
        }

    }
}
