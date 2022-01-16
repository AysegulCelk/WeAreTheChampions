using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    public class Match
    {
        public int MatchId { get; set; }
        
        public DateTime? MatchTime { get; set; }  //maçin zamanı 
        
        public int Team1Id { get; set; }
        public virtual Team Team1 { get; set; }
        
        
        public int Team2Id { get; set; }
        public virtual Team Team2 { get; set; }
       
        public int? Score1 { get; set; }
        
        public int? Score2 { get; set; }
        public Result? Result { get; set; }
        public virtual ICollection<Team> Teams { get; set; }


    }
}
