using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchUpEntryModel
    {
        /// <summary>
        /// Represents on team in the match up
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this particular team
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// Represents the match that this team came as the winner
        /// </summary>
        public MatchUpModel ParentMatchup { get; set; }
    }
}
