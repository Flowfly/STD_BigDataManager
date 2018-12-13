using Neo4j.Driver.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_BigDataManager
{
    class DataBase
    {

        public IDriver Driver { get; private set; }
        public DataBase()
        {
            this.Driver = GraphDatabase.Driver(Constants.URI, AuthTokens.Basic(Constants.DB_USER_NAME, Constants.DB_USER_PASSWORD));
        }

        public bool InsertData(string password)
        {


            using (var session = this.Driver.Session())
            {
                var insert = session.WriteTransaction(tx =>
                {
                    var result = tx.Run("CREATE (n:Password) " +
                                        "SET n.password = $password " +
                                        "RETURN n.password + ', from node ' + id(n)",
                        new { password });
                    return result.Single()[0].As<string>();
                });
                Console.WriteLine(insert);
            }

            return true;
        }
    }
}
