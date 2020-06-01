using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the amount required to register team for tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents list of all teams inside the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }
        /// <summary>
        /// Represents list of prizes given to different positions on the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; }
        public List<List<MatchUpModel>> Round { get; set; }

        public TournamentModel()
        {
            EnteredTeams = new List<TeamModel>();
            Prizes = new List<PrizeModel>();
            Round = new List<List<MatchUpModel>>();
        }
    }
}
