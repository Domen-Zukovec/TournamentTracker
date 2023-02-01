using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Predstavlja kaj je nagrada za določeno mesto
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Unikatni ključ za nagrado.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Številčni prikaz mesta (2 za drugo mesto, itd.)
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Izmišljeno ime mesta ( drugo mesto, skoraj prvi, za las lmao, itd.)
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Količina denarja, ki jo to mesto dobi (0 če ne uporabljamo)
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Procent skupne nagrade, ki jo prejme oseba na tem mestu
        /// 0 če ne uporabljamo
        /// 0.5 == 50%
        /// </summary>
        public double PrizePrecentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePrecentage = prizePercentageValue;
        }
    }
}
