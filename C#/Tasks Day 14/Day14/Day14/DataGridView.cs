using Day14.BLL;
using Day14.Context;
using Microsoft.EntityFrameworkCore;

namespace Day14
{
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
            LoadData();
        }
        //pubsContext Context = new pubsContext();

        private void DataGridView_Load(object sender, EventArgs e)
        {
            //Context.Titles.Load();

            //dataGridView1.DataSource=Context.Titles.Local.ToBindingList();
        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = TitleManager.SelectAllTitlesWithBinding();

            dataGridView1.Columns["Pub"].Visible = false;

            DataGridViewComboBoxColumn col = new();
            col.Name = "Pub";
            col.DataSource = PublisherManager.GetPublisherNamesWithIDs();
            col.DisplayMember = "PubName";
            col.ValueMember = "PubId";
            col.DataPropertyName = "PubId";

            dataGridView1.Columns.Add(col);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            TitleManager.Save();
        }
    }
}