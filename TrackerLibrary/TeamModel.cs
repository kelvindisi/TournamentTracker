using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Represent List of people of are members of the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; }

        /// <summary>
        /// Represent name of the team name
        /// </summary>
        public string TeamName { get; set; }

        // Initializes the team object, 
        public TeamModel()
        {
            TeamMembers = new List<PersonModel>();
        }
    }
}
