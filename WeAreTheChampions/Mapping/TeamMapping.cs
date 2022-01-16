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
    public class TeamMapping : EntityTypeConfiguration<Team>
    {
        public TeamMapping()
        {
            HasKey(x => x.TeamId)
                .Property(x => x.TeamId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.TeamName)
                .IsRequired()
                .HasMaxLength(100);

            HasMany<Player>(x => x.TeamPlayers)
                .WithRequired(x => x.Team)
                .HasForeignKey(x => x.TeamId)
                .WillCascadeOnDelete(false);
        }
    }
}
