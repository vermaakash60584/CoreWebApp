using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CoreWebApp.Models
{
    public class Player
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public string PTeam { get; set; }
        public double PAvg { get; set; }
    }
}
