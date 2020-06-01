using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the position the award should be given to
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the position name of the position
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the amount award to that position
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage of the award amount that should be given
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
