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
    public class MatchMapping : EntityTypeConfiguration<Match>
    {
        public MatchMapping()
        {
            HasKey(x => x.MatchId)
                .Property(x => x.MatchId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Team1Id)
                .IsRequired();

            Property(x => x.Team2Id)
                
                .IsRequired();


            Property(x => x.MatchTime)
               
               .IsRequired();
        }
    }
}
