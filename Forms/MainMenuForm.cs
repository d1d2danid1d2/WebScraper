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
    public partial class MainMenuForm : Form
    {
        public Form activeForm;
        private readonly SearchForm searchForm;

        public MainMenuForm(SearchForm searchForm)
        {
            InitializeComponent();
            this.searchForm = searchForm;
        }
        

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.formPanel.Controls.Add(childForm);
            this.formPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(searchForm, sender);
        }

    }
}
