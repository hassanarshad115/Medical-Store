using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
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
    public partial class rForm1 : Form
    {


        public rForm1()
        {
            InitializeComponent();
        }

        private void rForm1_Load(object sender, EventArgs e)
        {
            //ReportDocument r Path  ko add krna pryga usnig k zrye
            ReportDocument rdoc = new ReportDocument(); //reprotdocument ka obj bnaya ha ak

         
            //report.rpt jo sloution explorer ma ha uska cmplt path dena ha yha
            rdoc.Load(@"C:\Users\Hassan Arshad\Desktop\c#\Medical Store\Medical Store\report.rpt");

            //sqlconnection bnana hha
            string conn = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            SqlConnection c = new SqlConnection(conn);

            //sqldataadapter wala kam krma ha mgr second line gor sy smjh kr
            SqlDataAdapter adapter = new SqlDataAdapter("saw", c);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            //wo jo data set bnaya ta alg sy item m sy chose kr k usko yha use krna ha
            DataSet dst = new DataSet();
            adapter.Fill(dst, "DATAS"); //adapter ko use kr k krna ha

            rdoc.SetDataSource(dst);
            crystalReportViewer1.ReportSource = rdoc; //jsy datagridvew.DataSource krty h wse ye krna ha lazmi
            //reprot.rpt ki properties ma ja k copy to always lazmi krdyn
        }
    }
}
