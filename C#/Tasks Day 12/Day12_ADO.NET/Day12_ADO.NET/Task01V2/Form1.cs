using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Security.Policy;
using System.Windows.Forms;

namespace Day12_ADO.NET.Task01V2
{
    public partial class Form1 : Form
    {
        SqlCommand? com = null;
        SqlDataAdapter? adapter = null;
        DataTable? dt = null;

        public Form1()
        {
            InitializeComponent();
            dt = new();

            com = new("select p.*, c.CategoryName from products p join Categories c on p.CategoryID = c.CategoryID", SqlHelper.Connection);
            adapter = new(com);
        }
        
        private void Save_Click(object sender, EventArgs e)
        {
            if (adapter != null)
            {
                dataGridView1.EndEdit();

                try
                {
                    SqlHelper.OpenConnection();
                    foreach (DataRow row in dt.Rows)
                    {
                        int state = row.RowState switch
                        {
                            DataRowState.Deleted => 1,
                            DataRowState.Modified => 2,
                            DataRowState.Added => 3,
                            _ => 0
                        };

                        if (state != 0)
                        {
                            switch (state)
                            {
                                case 1: SqlHelper.Delete(row); break;
                                case 2: SqlHelper.Update(row); break;
                                case 3: SqlHelper.Insert(row); break;
                            };
                        }
                    }

                    MessageBox.Show("Updated Successfully");
                }
                catch (Exception)
                {
                    MessageBox.Show("Couldn't update due to existing refrences");
                    LoadData();
                }
                finally
                {
                    SqlHelper.CloseConnection();
                }
            }
        }

        private void LoadData()
        {
            SqlHelper.OpenConnection();

            if (SqlHelper.Connection.State == ConnectionState.Open)
            {
                dt?.Clear();
                dataGridView1.Columns.Clear();
                adapter?.Fill(dt);

                DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();

                comboBoxColumn.Items.AddRange(SqlHelper.Categories.Keys.ToArray());
                comboBoxColumn.DataPropertyName = "CategoryName";
                comboBoxColumn.HeaderText = "Category";
                comboBoxColumn.DisplayMember = "CategoryName";
                comboBoxColumn.ValueMember = "CategoryID";


                dataGridView1.DataSource = dt;
                dataGridView1.Columns.Add(comboBoxColumn);

                dataGridView1.Columns.RemoveAt(10);
                dataGridView1.Columns.RemoveAt(3);

                dataGridView1.Columns[^1].DisplayIndex = 3;
            }
            else
            {
                MessageBox.Show("Open a connection first!");
            }
        }

        private void Load_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            SqlHelper.CloseConnection();
            dt?.Clear();
        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            if (adapter != null)
            {
                dataGridView1.EndEdit();

                try
                {
                    SqlHelper.OpenConnection();
                    foreach (DataRow row in dt.Rows)
                    {
                        int state = row.RowState switch
                        {
                            DataRowState.Deleted => 1,
                            DataRowState.Modified => 2,
                            DataRowState.Added => 3,
                            _ => 0
                        };

                        if (state != 0)
                        {
                            switch (state)
                            {
                                case 1: SqlHelper.Delete(row); break;
                                case 2: SqlHelper.Update(row); break;
                                case 3: SqlHelper.Insert(row); break;
                            };
                        }
                    }

                    MessageBox.Show("Updated Successfully");
                }
                catch (Exception)
                {
                    MessageBox.Show("Couldn't update due to existing refrences");
                    LoadData();
                }
                finally
                {
                    SqlHelper.CloseConnection();
                }
            }
        }

        
    }
}
