using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HRMmobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginFlyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        public LoginFlyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new LoginFlyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class LoginFlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<LoginFlyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public LoginFlyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<LoginFlyoutPageFlyoutMenuItem>(new[]
                {
                    new LoginFlyoutPageFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new LoginFlyoutPageFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new LoginFlyoutPageFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new LoginFlyoutPageFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new LoginFlyoutPageFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}