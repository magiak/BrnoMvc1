using BrnoMvc1.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BrnoMvc1.Web.Configurations
{
    public class MovieConfiguration : EntityTypeConfiguration<Movie>
    {
        public MovieConfiguration()
            : this("dbo")
        {
        }

        public MovieConfiguration(string schema)
        {
            this.ToTable(nameof(Movie), schema);

            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Title).HasMaxLength(64);
        }
    }
}