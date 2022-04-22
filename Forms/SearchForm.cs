using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScraper.Forms
{

    public partial class SearchForm : Form
    {
        private readonly ISearchForCars searchForCars;

        public SearchForm(ISearchForCars searchForCars)
        {
            InitializeComponent();
            this.searchForCars = searchForCars;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string url = searchLink.Text;
            int result;
            bool nrParse = int.TryParse(pageCount.Text, out result);
            try
            {
                resultBox.DataSource = await searchForCars.GetAllCarsFromPages(result, url);
                resultBoxCount.Text = resultBox.Items.Count.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("The url might be wrong or the request was refused!");
            }
        }

        public void ResultBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultBox.MouseDoubleClick -= ResultBox_MouseDoubleClick;
            resultBox.MouseDoubleClick += ResultBox_MouseDoubleClick;

        }
        private void ResultBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenDetailForm(resultBox.SelectedItem.ToString());
        }

        private void OpenDetailForm(string url)
        {
            CarDetailForm detailForm = new();


            detailForm.GetDetails(url);
            detailForm.Show();

        }
    }
}
