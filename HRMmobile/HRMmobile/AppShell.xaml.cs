using HRMmobile.ViewModels;
using HRMmobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HRMmobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(ItemsPage), typeof(ItemsPage));
        }

    }
}
