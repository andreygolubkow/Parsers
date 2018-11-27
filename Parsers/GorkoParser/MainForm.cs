using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GorkoParser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void getListButton_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var url =
                @"https://api.gorko.ru/api/v2/directory/venues/?fields=metro%2Cparams%2Cpanorama_url%2Ccovers%2Crooms_count_text%2Caddress&city_id=3538&per_page=100&page=1";
            var data = await client.GetStringAsync(url);
            

            textBox1.Text = HttpUtility.UrlDecode(data.Replace(@"\u00", "%"), Encoding.UTF8); 
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
