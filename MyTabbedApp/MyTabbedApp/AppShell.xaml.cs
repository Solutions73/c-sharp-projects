using System;
using System.Collections.Generic;
using MyTabbedApp.ViewModels;
using MyTabbedApp.Views;
using Xamarin.Forms;

namespace MyTabbedApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
