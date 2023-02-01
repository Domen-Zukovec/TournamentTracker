﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        
        public static void InicializeConnetions (bool database, bool textFiles) 
        {
            if (database)
            {
                // TODO - set up the SQL connector properly
                SqlConnector sql = new SqlConnector ();
                Connections.Add (sql);
            }
            if (textFiles)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector ();
                Connections.Add (text);
            }
        }
    }
}