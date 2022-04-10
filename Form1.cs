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

namespace WebScraper
{
    public partial class Form1 : Form
    {
        private readonly ISearchForCars search;
        private readonly ICarDetails details;

        public Form1(ISearchForCars search,ICarDetails details)
        {
            InitializeComponent();
            this.search = search;
            this.details = details;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string url = linkSearch.Text;
            int result;
            bool pageCount = int.TryParse(numberOfPages.Text, out result);
            List<string> data = new List<string>();
            if (result != 0)
            {
                data.AddRange(await search.GetAllCarsFromPages(result, url));
                listBox1.DataSource = data;
                numberOfCars.Text = listBox1.Items.Count.ToString();
            }
            else
            {
                listBox1.DataSource = await search.GetCars(url);
                listBox1.SelectedItem.ToString();
                numberOfCars.Text = listBox1.Items.Count.ToString();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.listBox1.SelectedItem.ToString());
            listBox1.MouseDoubleClick -= ListBox1_MouseDoubleClick;
            listBox1.MouseDoubleClick += ListBox1_MouseDoubleClick;
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string link = listBox1.SelectedItem.ToString();
            Process p = new();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = link;

            p.Start();


        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            var url = textBox2.Text;
            
            listBox1.DataSource = await details.GetInfoAboutCar(url);
        }
    }
}
