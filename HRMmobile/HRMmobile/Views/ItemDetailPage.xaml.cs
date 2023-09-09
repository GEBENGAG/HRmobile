using HRMmobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace HRMmobile.Views
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