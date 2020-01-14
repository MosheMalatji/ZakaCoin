using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZakaCoin
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            this.Navigating += AppShell_Navigating;
            this.Navigated += AppShell_Navigated;
        }

        private void AppShell_Navigated(object sender, ShellNavigatedEventArgs e)
        {
        }

        private void AppShell_Navigating(object sender, ShellNavigatingEventArgs e)
        {

        }
    }
}
