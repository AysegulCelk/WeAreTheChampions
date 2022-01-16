using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    public class Color
    {
        public int ColorId { get; set; }
        
        public string ColorName { get; set; }
        public int ColorRed { get; set; } //renkler verilcek
        public int ColorBlue { get; set; } //renkler verilcek

        public int ColorGreen { get; set; } //renkler verilcek
        

        public override string ToString()
        {
            return ColorName;
        }
        public virtual ICollection<Team>Teams { get; set; }

    }
}
