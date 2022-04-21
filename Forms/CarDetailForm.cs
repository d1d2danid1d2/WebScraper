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

namespace WebScraper.Forms
{
    public partial class CarDetailForm : Form
    {
        private string url;
        public CarDetailForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public async void GetDetails(string url)
        {
            this.url = url;
            CarDetails details = new();
            nameTextbox.Text = await details.GetCarNameAsync(url);
            listBox1.DataSource = await details.GetInfoAboutCar(url);
        }

        private void CarDetailForm_Load(object sender, EventArgs e)
        {
           
        }

        private void pageOpenButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psInfo);
            
        }
    }
}
