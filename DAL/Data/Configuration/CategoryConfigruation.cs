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
    public class CategoryConfigruation : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);

            builder.HasData(
                new Category { Id = 1, Name = "Action" },
                new Category { Id = 2, Name = "Adventure" },
                new Category { Id = 3, Name = "RPG" },
                new Category { Id = 4, Name = "Shooter" },
                new Category { Id = 5, Name = "Survival" },
                new Category { Id = 6, Name = "Horror" }
            );
        }


    }
}
