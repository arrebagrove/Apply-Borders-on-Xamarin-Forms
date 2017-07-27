using Xamarin.Forms;
using System;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Spot.Views
{
	public partial class TermsConditionPage : ContentPage
	{
		public TermsConditionPage()
		{
			InitializeComponent();
		}

		void OnButtonClicked(object sender, EventArgs args)
		{
			var nameValue = PhoneEntry.Text;
			//DisplayAlert("Alert", "You have been alerted   " + nameValue, "OK");
			Onetimepass_data();

		}


		public async void Onetimepass_data()
		{
			//var client = new HttpClient();
			//client.BaseAddress = new Uri("https://api.smartchildinfo.com/sci_user_service/sci_user_service/otp_process");
			//string jsonData = "{\"action\":\"generate\":\"phone_number\":\"+919566621007\"}";
			//var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			//HttpResponseMessage response = await client.PostAsync("/foo/login", content);
			//// this result string should be something like: "{"token":"rgh2ghgdsfds"}"
			//var result = await response.Content.ReadAsStringAsync();
			//DisplayAlert("Alert", "You have been alerted   " + response, "OK");

			//Uri requestUri = new Uri("https://api.smartchildinfo.com/sci_user_service/sci_user_service/otp_process"); //replace your Url  
			//string jsonData = "{\"action\":\"generate\":\"phone_number\":\"+919566621007\"}";
			//string jsonData = @"{""action"":""generate"",""phone_number"":""+919566621007""}";
			//string json = "";
			//json = Newtonsoft.Json.JsonConvert.SerializeObject(jsonData);
			//var objClint = new System.Net.Http.HttpClient();
			//HttpResponseMessage respon = await objClint.PostAsync(requestUri, new StringContent(json, System.Text.Encoding.UTF8, "application/json"));
			//string responJsonText = await respon.Content.ReadAsStringAsync();

			//string jsonData = @"{""action"":""generate"",""phone_number"":""+919566621007""}";
			//var requestUrl = "https://api.smartchildinfo.com/sci_user_service/sci_user_service/otp_process";
			//string json = JsonConvert.SerializeObject(jsonData);
			//JObject postObject = await APIClient.Instance.HttpClientRequestAsync<JObject>(requestUrl, json);
			//int responseStatusCode = (int)postObject.Property("status_code");

			//if (responseStatusCode == 200)
			//{
			//	DisplayAlert("Alert", "You have been alerted   " + responseStatusCode, "OK");
			//}

		}

		async void OnAlertYesNoClicked(object sender, EventArgs e)
		{
			var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
		}
	}
}
