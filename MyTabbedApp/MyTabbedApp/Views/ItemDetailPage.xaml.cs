using System.ComponentModel;
using Xamarin.Forms;
using MyTabbedApp.ViewModels;

namespace MyTabbedApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
