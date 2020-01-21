using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using ZakaCoin.Models;

namespace ZakaCoin.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Preserve(AllMembers = true)]
    public partial class TabbedForm : ContentPage
    {
        public TabbedForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Clicked(object sender, System.EventArgs e)
        {
            //Do Something
        }

        private async void btnLogin_Clicked(object sender, System.EventArgs e)
        {

            Navigation.InsertPageBefore(new AppShell(), this);
            await Navigation.PopAsync();

        }

        private object AreCredentialsCorrect(User user)
        {
            throw new NotImplementedException();
        }
    }
}