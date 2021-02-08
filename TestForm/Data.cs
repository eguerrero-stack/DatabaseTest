using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace TestForm
{
    public class Data
    {
        public List<Legend> listLegend(string name)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDb")))
            {
                var output = connection.Query<Legend>("dbo.Legends_SelectByName @Name", new { Name = name }).ToList();
                return output;
            }
        }

    }
}
