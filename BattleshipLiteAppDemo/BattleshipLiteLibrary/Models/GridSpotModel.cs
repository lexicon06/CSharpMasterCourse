using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models
{
    public class GridSpotModel
    {
        public string SpotLetter { get; set; }
        public int SpotNumber { get; set; }
        //on these auto properties we can set default status to = anything easily
        public GridSpotStatus Status { get; set; } = GridSpotStatus.Empty;

    }
}
