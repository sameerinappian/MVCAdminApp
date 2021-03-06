﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace AdminApp.DAO
{
    public class BaseDAL
    {
        public BaseDAL()
        {

        }

        public IDbConnection OpenConnection()//for establish db connection
        {
            var connectionString = ConfigurationManager.ConnectionStrings["AdminAppCon"].ConnectionString;
            var cn = new SqlConnection(connectionString);
            IDbConnection connection = cn;
            cn.Open();
            return connection;
        }
    }
}
