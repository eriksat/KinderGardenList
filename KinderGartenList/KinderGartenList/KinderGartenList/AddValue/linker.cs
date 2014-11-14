using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KinderGartenList.AddValue
{
    public class linker
    {
        static public void Writer(string name, string sur, string age, string burn, string where, string info, string first, string last)
        {
            SqlConnection _cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\AdiK\documents\visual studio 2013\Projects\KinderGartenList\KinderGartenList\inform.mdf;Integrated Security=True");
            try
            {
              _cn.Open();
                SqlCommand cmd= new SqlCommand("insert into allin(name,sur,age,burn,where,info,first,last) values('"+name+"','"+sur+"','"+age+"','"+burn+"','"+where+"','"+info+"','"+first+"','"+last+"')",_cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Все информации сохранены !");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "AdmiN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { _cn.Close();}
            
        }

    }
}
