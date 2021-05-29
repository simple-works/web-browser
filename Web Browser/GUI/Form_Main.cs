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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            LoadPage();
        }

        private void LoadPage()
        {
            webBrowser_main.Url = API.GetUri(textBox_query.Text);
        }

        private void button_go_Click(object sender, EventArgs e)
        {
            LoadPage();
        }

        private void textBox_query_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            new Form_About().ShowDialog(this);
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            new Form_Settings().ShowDialog(this);
        }
    }
}
