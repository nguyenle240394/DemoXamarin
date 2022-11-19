using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public string url = "http://192.168.2.23:8081/";

        public LoginPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            string userCode = pUserName.Text;
            string passwordHash = pPassword.Text;
            url = url + "api/SaUsers/" + userCode + "/" + passwordHash;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                try
                {
                    HttpResponseMessage message = await client.GetAsync(url);
                    url = "http://192.168.2.23:8081/";
                    if (message.IsSuccessStatusCode)
                    {
                        await Navigation.PushAsync(new MainPage());
                    }
                    else
                    {
                        await DisplayAlert("Thông Báo", "Tài khoản hoặc mật khẩu sai, vui lòng kiểm tra lại", "OK");
                    }
                }
                catch (Exception)
                {
                    url = "http://192.168.2.23:8081/";
                    await DisplayAlert("Thông Báo", "Kết nối server không thành công", "OK");
                }
            }
        }
    }
}