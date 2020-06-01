using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchUpModel
    {
        /// <summary>
        /// Represents the entries of the tournament match
        /// </summary>
        public List<MatchUpEntryModel> Entries { get; set; }
        /// <summary>
        /// Represents tournament round winner team details
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represent the round number of the match
        /// </summary>
        public int MatchupRound { get; set; }

        /// <summary>
        /// Initializes the Entries (scores and team competing against) to empty list
        /// </summary>
        public MatchUpModel()
        {
            Entries = new List<MatchUpEntryModel>();
        }
    }
}
