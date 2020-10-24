using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFirebase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                tblVehicle.IsVisible=true;
            }
            else
            {
                tblVehicle.IsVisible = false;
            }
            
        }
    }
}