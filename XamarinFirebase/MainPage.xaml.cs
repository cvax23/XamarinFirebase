
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using XamarinFirebase.Helper;
using XamarinFirebase.Model;
using System.Runtime.InteropServices;

namespace XamarinFirebase
{
    public partial class MainPage : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allPersons = await firebaseHelper.GetAllPersons();
            lstPersons.ItemsSource = allPersons;
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            await firebaseHelper.AddPerson((txtId.Text), txtName.Text);
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            await DisplayAlert("Success", "Driver Added Successfully", "OK");
            var allPersons = await firebaseHelper.GetAllPersons();
            lstPersons.ItemsSource = allPersons;
        }

        private async void BtnRetrive_Clicked(object sender, EventArgs e)
        {
            var person = await firebaseHelper.GetPerson((txtId.Text));
            if (person != null)
            {
                txtId.Text = person.DriverId.ToString();
                txtName.Text = person.FirstName;
                await DisplayAlert("Success", "Driver Retrive Successfully", "OK");

            }
            else
            {
                await DisplayAlert("Success", "No Driver Available", "OK");
            }

        }

        private async void BtnUpdate_Clicked(object sender, EventArgs e)
        {
            await firebaseHelper.UpdatePerson((txtId.Text), txtName.Text);
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            await DisplayAlert("Success", "Driver Updated Successfully", "OK");
            var allPersons = await firebaseHelper.GetAllPersons();
            lstPersons.ItemsSource = allPersons;
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            await firebaseHelper.DeletePerson((txtId.Text));
            await DisplayAlert("Success", "Driver Deleted Successfully", "OK");
            var allPersons = await firebaseHelper.GetAllPersons();
            lstPersons.ItemsSource = allPersons;
        }

        private async void btnOfferTrip_ClickedAsync(object sender, EventArgs e)
        {
            await firebaseHelper.OfferTrip();
            await DisplayAlert("Succes", "Trip Offertered", "OK");
        }
    }
}

