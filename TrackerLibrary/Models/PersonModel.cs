using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Predstavlja eno osebo
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Unikatni ključ za person.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ime osebe
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Priimek osebe
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// e-mail naslov osebe
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Telefonska števila osebe
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
