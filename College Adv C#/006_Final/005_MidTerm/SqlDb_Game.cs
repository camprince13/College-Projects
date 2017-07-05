//Cameron Prince
//Original 12/15/2014
//Modified 12/15/2014
//SQL server database connection


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient; //SQL database
using System.Data; //database

namespace _005_MidTerm
{
    class SqlDb_Game
    {

        public static string GetConnected()
        {
            string result = @"Server=sql.neit.edu;Database=SE255_CPrince;User Id=SE255_CPrince;Password=001295039;";
            return result;
        }

    }
}
