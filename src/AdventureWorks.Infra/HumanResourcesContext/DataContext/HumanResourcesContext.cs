using AdventureWorks.Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AdventureWorks.Infra.HumanResourcesContext.DataContext
{
    public class HumanResourcesContext : IDisposable
    {
        public SqlConnection Connection { get; private set; }

        public HumanResourcesContext()
        {
            Connection = new SqlConnection(Settings.ConnectionStringDev);
            Connection.Open();
        }

        public void Dispose()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
    }
}
