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
using GorkoRu;

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
            var restList = new List<Restaurant>();
            HttpClient client = new HttpClient();
            var priceCat = "3";
            var cityId = "3538";
            var firstUrl =
                @"https://api.gorko.ru/api/v2/directory/venues/?fields=metro%2Cparams%2Cpanorama_" +
                "url%2Ccovers%2Crooms_count_text%2Caddress&city_id=" + cityId + "&per_page=100&page=1&price="+priceCat;
            var firstData = await client.GetStringAsync(firstUrl);
            var meta = Welcome.FromJson(firstData).Meta;

            for (int i = 1; i <= meta.PagesCount; i++)
            {
                var url =
                    @"https://api.gorko.ru/api/v2/directory/venues/?fields=metro%2Cparams%2Cpanorama_"+
                    "url%2Ccovers%2Crooms_count_text%2Caddress&city_id="+cityId+"&per_page=100&page="+i + "&price=" + priceCat;
                var data = await client.GetStringAsync(url);

                var welcome = Welcome.FromJson(data);
                restList.AddRange(welcome.Restaurants);
                
            }
            //URL для одного элемента
            var restUrl =
                @"https://api.gorko.ru/api/v2/restaurants/25471?embed=rooms&fields=address,params,covers,panorama_matterport_url";
            foreach (var restaurant in restList)
            {
                textBox1.Text += restaurant.Type.Plural == Plural.БанкетныеЗалы;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
