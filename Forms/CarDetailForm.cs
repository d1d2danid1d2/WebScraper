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
    public partial class CarDetailForm : Form
    {
        
        public CarDetailForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public async void GetDetails(string url)
        {
            CarDetails details = new();
            linkTextbox.Text = url;
            listBox1.DataSource = await details.GetInfoAboutCar(url);
        }

        private void CarDetailForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
