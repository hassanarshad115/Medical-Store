using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Store
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginbutton1_Click(object sender, EventArgs e)
        {
            bool isusername, ispassword;
            getLogin(out isusername, out ispassword);
            if (isusername && ispassword)
            {
                this.Hide();
                //MessageBox.Show("successfully login");
                showDataForm sdf = new showDataForm();
                sdf.Show();

            }
            else
            {
                if (!isusername)
                {
                    MessageBox.Show("UserName is not Correct","ERROR!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    usernametextBox2.Clear();
                    usernametextBox2.Focus();
                }
                else
                {
                    MessageBox.Show("Password is not Correct", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordtextBox1.Clear();
                    passwordtextBox1.Focus();

                }
            }
        }

        private void getLogin(out bool isusername, out bool ispassword)
        {
            string c = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            SqlConnection conn = new SqlConnection(c);
            SqlCommand cmd = new SqlCommand("l", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            cmd.Parameters.Add("@isu", SqlDbType.Bit).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@isp", SqlDbType.Bit).Direction = ParameterDirection.Output;

            cmd.Parameters.AddWithValue("@u", usernametextBox2.Text);
            cmd.Parameters.AddWithValue("@p", passwordtextBox1.Text);

            cmd.ExecuteNonQuery();

            isusername = (bool)cmd.Parameters["@isu"].Value;
            ispassword = (bool)cmd.Parameters["@isp"].Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordtextBox1.PasswordChar = default(char);
            }
            if(!checkBox1.Checked)
            {
                passwordtextBox1.PasswordChar=Convert.ToChar("*");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
