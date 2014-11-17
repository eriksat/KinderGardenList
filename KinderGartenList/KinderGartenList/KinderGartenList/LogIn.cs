using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KinderGartenList
{
    public partial class LogIn : Form
    {
        private SqlConnection con;
                private SqlDataAdapter cmd;
        private DataTable dt;
       
        private string userLogin;
                private string query;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\DOCUMENTS\project C#\MyfirstProject GitHub\KinderGardenList\KinderGartenList\KinderGartenList\KinderGartenList\inform.mdf;Integrated Security=True");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            if (comboBox1.Text == "" && textBox2.Text=="") {
                errorProvider1.SetError(comboBox1, "Please Choose Users!");
                errorProvider1.SetError(textBox2,"Please Fill Password!");
            }
            else if (comboBox1.Text != "" && textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Please Fill Password!");
            }
            else if (comboBox1.Text == "" && textBox2.Text != "")
            {
                errorProvider1.SetError(comboBox1, "Please Choose Users!"); 
            }
            else
            {
               
                try
                {

              

                    
                    if(con.State!=ConnectionState.Open)
                    con.Open();
                  
                    query = "select count(*) from Admin where USERNAME = '" + comboBox1.Text + "' and PASSWORD = '" + textBox2.Text + "' ";
                    MessageBox.Show(query);
                    cmd = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    cmd.Fill(dt);
                    if (dt.Rows[0][0].ToString() =="1")
                    {
                        userLogin = comboBox1.Text;
                     con.Close();
                        if (userLogin == "Admin")
                        {
                            this.Hide();
                            AdminMainForm frAdmin = new AdminMainForm();
                            frAdmin.Show();
                        }
                        else //if(userLogin   == "User")
                        {
                            this.Hide();
                         
                            UserMainForm frUser = new UserMainForm();
                                frUser.Show();
                            
                        }

                    }

                    else
                    {
                        MessageBox.Show("LOGIN OR PASSWORD INCORRECT!");
                    }


                }
                catch (Exception kataException)
                {
                    MessageBox.Show(kataException.Message);
                 
                }
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBox1,"");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2,"");
        }

      
    }
}
