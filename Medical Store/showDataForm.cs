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
    public partial class showDataForm : Form
    {
        public showDataForm()
        {
            InitializeComponent();
        }

       
        private void showDataForm_Load(object sender, EventArgs e)
        {   
            
            dataGridView1.DataSource = getData("select * from itbl");
            dataGridView1.Columns[0].Visible = false;
        }


        DataTable dt;
        private DataTable getData(string sp)
        {
            dt = new DataTable();
            string c = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            SqlConnection conn = new SqlConnection(c);
            SqlDataAdapter adapter = new SqlDataAdapter(sp, c);
            adapter.Fill(dt);
            return dt;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "ItemName like '%" + textBox1.Text.Trim() + "%'";

        }
        /// <summary>
        /// yha nichy doubleclick ma agr dgv pr double click krygy tw insert wala form open hojayga 
        /// uska ak obj bnaya ha obj k zrye insert ma jo properties bnae h usko access kia ha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            this.Hide();
            insertForm obj = new insertForm();

           
            int updatedata = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            string o =Convert.ToString( dataGridView1.Rows[updatedata].Cells["ItemName"].Value );
            string o1 = Convert.ToString(dataGridView1.Rows[updatedata].Cells["Price"].Value);
            string o2 = Convert.ToString(dataGridView1.Rows[updatedata].Cells["Quantity"].Value);
            string o3 = Convert.ToString(dataGridView1.Rows[updatedata].Cells["CompanyName"].Value);
            string o4 = Convert.ToString(dataGridView1.Rows[updatedata].Cells["Date"].Value);

            obj.itemnamep = o.ToString();
            obj.pricep = o1.ToString();
            obj.quantityp = o2.ToString();
            obj.companynamep = o3.ToString();
            obj.datep = o4.ToString();

            //obj.buttonp =Convert.ToString(false);//update k lye ye ta r yha convert krna pra bool sy string ma
            obj.ShowDialog();
            
        }

        private void insertRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forInsertUpdateDeleteToolstrip();
        }

        private void forInsertUpdateDeleteToolstrip()
        {
            insertForm i = new insertForm();
            this.Hide();
            i.Show();
        }

        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forInsertUpdateDeleteToolstrip();
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forInsertUpdateDeleteToolstrip();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "CompanyName like '%" + textBox2.Text.Trim() + "%'";
        }

        private void reprotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rForm1 f = new rForm1();
            f.ShowDialog();
        }

        private void printbutton1_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("yha kch likhna ha",new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataView dv = dt.DefaultView;
            //dv.RowFilter = "ItemName like '%" + comboBox1.Text + "%'";          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
