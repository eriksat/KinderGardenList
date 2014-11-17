using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderGartenList
{
    class SqlQuery1
    {
        private SqlConnection con;
  

        public SqlQuery1()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\DOCUMENTS\project C#\MyfirstProject GitHub\KinderGardenList\KinderGartenList\KinderGartenList\KinderGartenList\inform.mdf;Integrated Security=True");
        }

        public SqlConnection ConnectSQl()
        {
            return con;
        }

        public void SqlOpen()
        {
            if(con == null)
                con.Open();
        }

        public void SqlClose()
        {
            if(con!=null)
                con.Close();
        }


    }
}
