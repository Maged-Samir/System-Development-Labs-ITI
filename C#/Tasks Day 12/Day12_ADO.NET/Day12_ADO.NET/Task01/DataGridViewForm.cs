using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Policy;

namespace Day12_ADO.NET
{
    public partial class DataGridViewForm : Form
    {
        public DataGridViewForm()
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
            SqlCmd = new SqlCommand("select p.ProductID,p.ProductName,c.CategoryName,p.CategoryID from Products P join Categories C on p.CategoryID=c.CategoryID", SqlCon);
            SqlDA = new SqlDataAdapter(SqlCmd);

            DtPrds =new DataTable();

            SqlDA.Fill(DtPrds);


            //DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            //var list11 = new List<string>() { "10", "30", "80", "100" };
            //column.DataSource = list11;
            //column.HeaderText = "Money";
            //column.DataPropertyName = "Money";
            //column.DisplayMember = "Money";
            //dataGridView1.Columns.Add(column);


            var cmbColumn = new DataGridViewComboBoxColumn();
            cmbColumn.DataPropertyName = "CategoryID";      // this is the property in UserDetails table
            cmbColumn.ValueMember = "CategoryID";           // this is the property in UserTypes table
            cmbColumn.DisplayMember = "CategoryName";       // again this property is in UserTypes table
            cmbColumn.DataSource = DtPrds; ;  // this binding source is connected with UserTypes table
            this.dataGridView1.Columns.Add(cmbColumn);

            dataGridView1.DataSource = DtPrds;


        }

        private void UpdateData()
        {
            SqlCommandBuilder commandBuilder= new SqlCommandBuilder(SqlDA);
            SqlDA.InsertCommand=commandBuilder.GetInsertCommand();
            SqlDA.UpdateCommand = commandBuilder.GetUpdateCommand();
            SqlDA.DeleteCommand = commandBuilder.GetDeleteCommand();
            MessageBox.Show("Item Updated Succssuflly");
        }


        private void DataGridViewForm_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
            SqlDA.Fill(DtPrds);

            dataGridView1.DataSource = DtPrds;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateData(); 



            dataGridView1.EndEdit();
            SqlDA.Update(DtPrds);
        }
    }


     
}