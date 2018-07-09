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
    public partial class insertForm : Form
    {
        public insertForm()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet(); //dataset ko insert ma use kia hoga
        SqlCommand cm;

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
                MessageBox.Show("Only Enter Number", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// insert ma ly kr ana ha data islye jha data ly kr ana ho wha properties bnyge
        /// r form load event sy uper properties bnyge r form load event ma properties ma js
        /// textbox ma values assign krwani ho us textbox.text k agy properties ka name dyna ha
        /// is sy phly ho skta h k jha sy properties ly kr ani ho to wha ja kr phly
        /// jha functionalites ly kr ani ho us form ka obj bnaygy r nechy isko show ya showdialog krygy
        /// f jsy double click event k andr code likha hoa h isko smjh kr kry asy 
        /// </summary>
        public string itemnamep { get; set; }
        public string pricep { get; set; }
        public string quantityp { get; set; }
        public string companynamep { get; set; }
        public string datep { get; set; }
        public string buttonp { get; set; }

        private void button1_Click(object sender, EventArgs e)

        {
            if (isEmpty())
            {
                string c = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
                SqlConnection conn = new SqlConnection(c);

                 cm = new SqlCommand("select * from itbl where ItemName='" + itemnametextBox1.Text.Trim() + "'", conn);
                SqlDataAdapter ad = new SqlDataAdapter(cm);
                ad.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Item Name "+itemnametextBox1.Text+" is Already Exist", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    showDataForm s = new showDataForm();
                    s.Show();
                }
                else
                {
                  
                    cm = new SqlCommand("i", conn);
                    cm.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cm.Parameters.AddWithValue("@itemname", itemnametextBox1.Text.Trim());
                    cm.Parameters.AddWithValue("@price", pricetextBox2.Text.Trim());
                    cm.Parameters.AddWithValue("@quantity", quantitytextBox3.Text.Trim());
                    cm.Parameters.AddWithValue("@companyname", companynametextBox4.Text.Trim());
                    cm.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);


                    cm.ExecuteNonQuery();

                    MessageBox.Show("Enter Data Successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    showDataForm obj = new showDataForm();
                    obj.ShowDialog();




                }
            }
        }
        private bool isEmpty()
        {
            if (itemnametextBox1.Text == string.Empty)
            {
                MessageBox.Show("Item Name TextBox is Empty", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                itemnametextBox1.Focus();
                return false;
            }
            if (pricetextBox2.Text == string.Empty)
            {
                MessageBox.Show("Price TextBox is Empty", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pricetextBox2.Focus();
                return false;
            }
            if (quantitytextBox3.Text == string.Empty)
            {
                MessageBox.Show("Quantity TextBox is Empty", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantitytextBox3.Focus();
                return false;
            }
            if (companynametextBox4.Text == string.Empty)
            {
                MessageBox.Show("Item Name TextBox is Empty", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantitytextBox3.Focus();
                return false;
            }

            return true;
        }

        private void quantitytextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
                MessageBox.Show("Only Enter Number", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void insertForm_Load(object sender, EventArgs e)//form load event ma ye sb krna ha
        {

            itemnametextBox1.Text = itemnamep;
            pricetextBox2.Text = pricep;
            quantitytextBox3.Text = quantityp;
            companynametextBox4.Text = companynamep;
            dateTimePicker1.Text = datep;
            //insertbutton1.Visible = Convert.ToBoolean(buttonp); //ye insert button ko hide krny k lye ha convert lazmi hoga


        }


        //....yha sy uper tk he smjhna ha
        private void updatebutton4_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                DialogResult result = MessageBox.Show("Do You Want To Update Records ???", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string c = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
                    SqlConnection conn = new SqlConnection(c);
                    SqlCommand cmd = new SqlCommand("up", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@itemname", itemnametextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", pricetextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@quantity", quantitytextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@companyname", companynametextBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Update Data Successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    showDataForm obj = new showDataForm();
                    obj.ShowDialog();
                }

            }
        }
        private void deletebutton2_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                DialogResult result = MessageBox.Show("Do You Want To Delete Records ???", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string c = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
                    SqlConnection conn = new SqlConnection(c);
                    SqlCommand cmd = new SqlCommand("del", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@itemname", itemnametextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", pricetextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@quantity", quantitytextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@companyname", companynametextBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Delete Data Successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    showDataForm obj = new showDataForm();
                    obj.ShowDialog();
                }
            }

        }
    }
}