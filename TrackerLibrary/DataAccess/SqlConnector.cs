using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method actually save to the DB
        /// <summary>
        /// Shrani novo nagrado v DB
        /// </summary>
        /// <param name="model">
        /// Informacija o nagradi
        /// </param>
        /// <returns>
        /// Informacijo o nagradi in unikaten ID
        /// </returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
