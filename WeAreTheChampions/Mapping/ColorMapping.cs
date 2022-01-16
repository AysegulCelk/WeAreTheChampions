using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreTheChampions.Models;

namespace WeAreTheChampions.Mapping
{
    public class ColorMapping : EntityTypeConfiguration<Color>
    {
        public ColorMapping()
        {
            HasKey(x => x.ColorId)
                .Property(x => x.ColorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
        }
    }
}
