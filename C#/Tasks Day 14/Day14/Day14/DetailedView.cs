using Day14.BLL;
using Day14.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day14
{
    public partial class DetailedView : Form
    {
        BindingNavigator bNav;
        public DetailedView()
        {
            InitializeComponent();
            bSrc.DataSource = TitleManager.SelectAllTitlesWithBinding();

            bNav = new(bSrc);
            Controls.Add(bNav);

            price.TextChanged += (sender, e) =>
            {
                ((Title)bSrc.Current).Price = Convert.ToDecimal(price.Text);
            };

            advance.TextChanged += (sender, e) =>
            {
                ((Title)bSrc.Current).Advance = Convert.ToDecimal(advance.Text);
            };

            royalty.TextChanged += (sender, e) =>
            {
                ((Title)bSrc.Current).Royalty =Convert.ToInt16( royalty.Text);
            };

            ytd.TextChanged += (sender, e) =>
            {
                ((Title)bSrc.Current).YtdSales =Convert.ToInt16( ytd.Text);
            };
        }

        private void DetailedView_Load(object sender, EventArgs e)
        {
            publisherCombo.DataSource = PublisherManager.GetPublisherNamesWithIDs();
            publisherCombo.DisplayMember = "pub_name";
            publisherCombo.ValueMember = "PubId";


            titleId.DataBindings.Add("Text", bSrc, "TitleID");
            title.DataBindings.Add("Text", bSrc, "Title1");
            type.DataBindings.Add("Text", bSrc, "Type");
            publisherCombo.DataBindings.Add("SelectedValue", bSrc, "PubID");
            price.DataBindings.Add("Text", bSrc, "Price");
            advance.DataBindings.Add("Text", bSrc, "Advance");
            royalty.DataBindings.Add("Text", bSrc, "Royalty");
            ytd.DataBindings.Add("Text", bSrc, "YTDSales");
            notes.DataBindings.Add("Text", bSrc, "Notes");
            publishDate.DataBindings.Add("Text", bSrc, "PubDate");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            bSrc.EndEdit();
            if (!TitleManager.Save())
            {
                bSrc.DataSource = TitleManager.SelectAllTitlesWithBinding();
                bNav.BindingSource = bSrc;
                MessageBox.Show("Couldn't delete due to refrence conflict");
            }
        }
    }
}
