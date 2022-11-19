using Demo.model;
using Demo.Model;
using Demo.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage
    {
        string url = "http://192.168.2.23:8081/";
        public MainPage()
        {
            InitializeComponent();
            getApiBmwCagor();
        }

        public async void getApiBmwCagor()
        {
            url += "api/DmBillOfLadings";
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync(url);
            var listBillOfLadings = JsonConvert.DeserializeObject<List<BillOfLading>>(json);
            plistBmwCargo.ItemsSource = listBillOfLadings;
        }
    }
}
