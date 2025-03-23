using DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Configuration
{
    public class GameDeviceConfiguration : IEntityTypeConfiguration<GameDevice>
    {
        public void Configure(EntityTypeBuilder<GameDevice> builder)
        {
            builder.HasKey(c => new { c.GameId, c.deviceId });
           
        }
    }
}
