using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO.Persistence
{
    class conexao
    {
        private String connectionString;

        public String getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            return connectionString;
        }
    }
}
