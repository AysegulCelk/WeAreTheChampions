using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public int? TeamId { get; set; }
        public virtual Team Team  { get; set; }
        
        public string PlayerName { get; set; }
        public override string ToString()
        {
            return PlayerName;
        }

    }
}
