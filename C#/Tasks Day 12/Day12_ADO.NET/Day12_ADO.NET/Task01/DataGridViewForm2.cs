using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Day12_ADO.NET
{
    public partial class DataGridViewForm2 : Form
    {
        public DataGridViewForm2()
        {
            InitializeComponent();
            LoadData();

        }
        string connectionString = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True;Encrypt=false";
        SqlConnection SqlCon;
        SqlCommand SqlCmd;
        SqlDataAdapter SqlDA;
        DataTable DtPrds;
        private void LoadData()
        {
            SqlCon = new SqlConnection(connectionString);
            SqlCmd = new SqlCommand("select p.ProductID,p.ProductName,c.CategoryName,p.CategoryID from Products P join Categories C on p.CategoryID=c.CategoryID", SqlCon);
            SqlDA = new SqlDataAdapter(SqlCmd);

            DtPrds = new DataTable();

            //var combox = (DataGridViewComboBoxColumn)dataGridView1.Columns["CategoryName"];
            //combox.DisplayMember = "CategoryName";
            //combox.ValueMember = "CategoryID";

            dataGridView1.DataSource = DtPrds;

        }

        private void DataGridViewForm2_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
