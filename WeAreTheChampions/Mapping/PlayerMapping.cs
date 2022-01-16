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
    public class PlayerMapping : EntityTypeConfiguration<Player>
    {
        public PlayerMapping()
        {
            HasKey(x => x.PlayerId)
                .Property(x => x.PlayerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PlayerName)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
