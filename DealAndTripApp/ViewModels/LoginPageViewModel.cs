
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using DealAndTripApp.Services;
using DealAndTripApp.Models;
using Xamarin.Essentials;
using System.Linq;

namespace DealAndTripApp.ViewModels
{
    class LoginPageViewModel : BaseViewModel
    {
        public LoginPageViewModel()
        {
            userNameOrEmail = "";
            password = "";
            SubmitCommand = new Command(Submit);
        }

        private async void Submit()
        {
            DealAndTripAPIProxy proxy = DealAndTripAPIProxy.CreateProxy();
            try
            {
                User u = await proxy.LoginAsync(UserNameOrEmail, Password);
                if (u != null)
                    ((App)App.Current).currentUser = u;
                else
                    ErrorMessege = "Somthing went wrong";
            }
            catch (Exception)
            {
                ErrorMessege = "Somthing went wrong";
            }
        }
        private string errorMessege;
        public string ErrorMessege
        {
            get
            {
                return errorMessege;
            }
            set
            {
                if(errorMessege != value)
                {
                    errorMessege = value;
                    OnPropertyChanged();
                }
            }
        }

        private string userNameOrEmail;
        public string UserNameOrEmail
        {
            get
            {
                return userNameOrEmail;
            }
            set
            {
                if (userNameOrEmail != value)
                {
                    userNameOrEmail = value;
                    OnPropertyChanged();
                }
            }
        }
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }
        public ICommand SubmitCommand { get; set; }

        
    }
}
