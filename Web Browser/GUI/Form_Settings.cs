using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebBrowser.Properties;

namespace WebBrowser
{
    public partial class Form_Settings : Form
    {
        public Form_Settings()
        {
            InitializeComponent();
        }

        private void button_resetSearchEngine_Click(object sender, EventArgs e)
        {
            textBox_searchEngine.Text = API.SearchEngineBaseUrl.Google;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!API.IsValidUrl(textBox_searchEngine.Text))
            {
                MessageBox.Show("Invalid Search Engine Base Url", Application.ProductName);
                textBox_searchEngine.Focus();
                textBox_searchEngine.SelectAll();
            }
            else
            {
                Settings.Default.SearchEngineBaseUrl = textBox_searchEngine.Text;
                Settings.Default.Save();
                Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
