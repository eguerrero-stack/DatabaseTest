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
    public class DataAccess

    {
        public List<Legend> listLegend(string name)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDatabase")))
            {
                var output = connection.Query<Legend>("dbo.Legends_SelectByLastName @LastName", new { LastName = name }).ToList();
                return output;
            }
        }

        public bool addLegend(string firstName, string lastName, string weapon)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDatabase")))
            {
                try
                {
                    Legend newLegend = new Legend { FirstName = firstName, LastName = lastName, Weapon = weapon };
                    List<Legend> legends = new List<Legend>();

                    legends.Add(newLegend);

                    connection.Execute("dbo.Legends_Insert @Id, @FirstName, @LastName, @Weapon", legends);

                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
             
            }
        }

    }
}
