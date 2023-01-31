using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Predstavlja eno ekipo na tekmi
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Predstavlja eno ekipo na tekmi
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Predstavlja točke za to ekipo
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Predstavlja tekmo na kateri
        /// je ta ekipa zmagala.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
