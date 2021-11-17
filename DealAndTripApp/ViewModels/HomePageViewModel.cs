using System;
using System.Collections.Generic;
using System.Text;

namespace DealAndTripApp.ViewModels
{
    class HomePageViewModel : BaseViewModel
    {
        public HomePageViewModel()
        {
            UserName = ((App)App.Current).currentUser.UserName;
        }
        private string userName;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                if(userName != value)
                {
                    userName = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
