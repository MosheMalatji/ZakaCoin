using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ZakaCoin.Models;
using ZakaCoin.Views;
using ZakaCoin.ViewModels;

namespace ZakaCoin.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        public Transaction Transaction { get; set; }

        public ItemsPage()
        {
            InitializeComponent();
            Transaction = new Transaction
            {
                PrivateKey = "L3aq7WPiSois3N7GxTr6ZSXMNdfbAZWebiYvKK5AUBCijk95rL",
                Sender = "18jp31DcT3n5vsYHGVhhQa2qavEve4EUoQ",
            };

            BindingContext = this;
        }


        async void CreateSign_Clicked(object sender,EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        async void btnSave_Clicked(object sender, EventArgs e)
        {
            Credential.PublicKey = Transaction.Sender;
            Credential.PrivateKey = Transaction.PrivateKey;

            await DisplayAlert("Credential", "Keys Updated", "Ok");

        }

        private void BtnMenu_Tapped(object sender, EventArgs e)
        {
        }
    }
}