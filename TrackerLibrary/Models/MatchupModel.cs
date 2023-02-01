using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Predstavlja eno tekmo na turnirju.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Set ekip, ki so tekmovale na tej tekmi
        /// </summary>
        public List<MatchupEntryModel> Entryes { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Zmagovalec tekme
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Del katere runde je ta tekma.
        /// </summary>
        public int MacthupRound { get; set; }
    }
}
