using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Day12_ADO.NET
{
    public partial class DetailedViewForm : Form
    {
        public DetailedViewForm()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True;Encrypt=false";
        SqlConnection SqlCon;
        SqlCommand SqlCmd;
        SqlDataAdapter SqlDA;
        DataTable DtPrds;
        private void LoadData()
        {
            SqlCon = new SqlConnection(connectionString);
            SqlCmd = new SqlCommand("select p.ProductID,p.ProductName,p.UnitPrice,p.UnitsInStock,p.CategoryID,c.CategoryName from Products p join Categories c on p.CategoryID=c.CategoryID\r\n", SqlCon);
            SqlDA = new SqlDataAdapter(SqlCmd);
            DtPrds = new DataTable();
            SqlDA.Fill(DtPrds);

         
        }

        private void DetailedViewForm_Load(object sender, EventArgs e)
        {
            LoadData();

            BindingSource bindingSource = new BindingSource(DtPrds, "");


            label1.DataBindings.Add("Text", bindingSource, "ProductID");
            txtName.DataBindings.Add("Text", bindingSource, "ProductName");
            txtPrice.DataBindings.Add("Text", bindingSource, "UnitPrice");
            txtStock.DataBindings.Add("Text", bindingSource, "UnitsInStock");

            comboBox1.DataSource = DtPrds;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            comboBox1.DataBindings.Add("SelectedValue", bindingSource, "CategoryID");
            

            button1.Click += (sender, e) => bindingSource.MoveNext();
            button2.Click += (sender, e) => bindingSource.MovePrevious();

            BindingNavigator bindingNavigator= new BindingNavigator(bindingSource);
            this.Controls.Add(bindingNavigator);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
