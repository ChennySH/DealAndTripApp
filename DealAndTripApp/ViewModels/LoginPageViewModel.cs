
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using DealAndTripApp.Services;
using DealAndTripApp.Models;
using DealAndTripApp.Views;
using Xamarin.Essentials;
using System.Linq;

namespace DealAndTripApp.ViewModels
{
    class LoginPageViewModel : BaseViewModel
    {
        public LoginPageViewModel()
        {
            UserNameOrEmail = "";
            Password = "";
            SubmitCommand = new Command(Submit);
        }

        private async void Submit()
        {
            DealAndTripAPIProxy proxy = DealAndTripAPIProxy.CreateProxy();
            try
            {
                bool allValuesVliadted = ValidationAllValues();
                if (!allValuesVliadted)
                {
                    await App.Current.MainPage.DisplayAlert("Login Failed", "Please check all your values are validated", "Okay");
                }
                else
                {
                    User u = await proxy.LoginAsync(UserNameOrEmail, Password);
                    if (u != null)
                    {
                        ((App)App.Current).currentUser = u;
                        MoveToHomePage();
                    }
                    else
                        await App.Current.MainPage.DisplayAlert("Login Failed", "Something went wrong", "Okay");
                }
            }
            catch (Exception)
            {
                await App.Current.MainPage.DisplayAlert("Login Failed", "Something went wrong", "Okay");
            }
        }
        public async void MoveToHomePage()
        {
            HomePage homePage = new HomePage();
            await App.Current.MainPage.Navigation.PushAsync(homePage);
        }
        #region Properties

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
                    UsernameOrEmailValidation();
                }
            }
        }
        private string userNameOrEmailErrorMessege;
        public string UserNameOrEmailErrorMessege
        {
            get
            {
                return userNameOrEmailErrorMessege;
            }
            set
            {
                if(userNameOrEmailErrorMessege != value)
                {
                    userNameOrEmailErrorMessege = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool userNameOrEmailErrorMessegeIsVisible;
        public bool UserNameOrEmailErrorMessegeIsVisible
        {
            get
            {
                return userNameOrEmailErrorMessegeIsVisible;
            }
            set
            {
                if (userNameOrEmailErrorMessegeIsVisible != value)
                {
                    userNameOrEmailErrorMessegeIsVisible = value;
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
                    PasswordValidation();
                }
            }
        }
        private string passwordErrorMessege;
        public string PasswordErrorMessege
        {
            get
            {
                return passwordErrorMessege;
            }
            set
            {
                if (passwordErrorMessege != value)
                {
                    passwordErrorMessege = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool passwordErrorMessegeIsVisible;
        public bool PasswordErrorMessegeIsVisible
        {
            get
            {
                return passwordErrorMessegeIsVisible;
            }
            set
            {
                if (passwordErrorMessegeIsVisible != value)
                {
                    passwordErrorMessegeIsVisible = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #region ValidationMethods
        public bool ValidationAllValues()
        {
            UsernameOrEmailValidation();
            PasswordValidation();
            return (!(UserNameOrEmailErrorMessegeIsVisible || PasswordErrorMessegeIsVisible));
        }
        public void UsernameOrEmailValidation()
        {
            if (string.IsNullOrEmpty(UserNameOrEmail))
            {
                UserNameOrEmailErrorMessege = "Please enter your username or email";
                UserNameOrEmailErrorMessegeIsVisible = true;
            }
            else
            {
                UserNameOrEmailErrorMessege = "";
                UserNameOrEmailErrorMessegeIsVisible = false;
            }
        }
        public void PasswordValidation()
        {
            if (string.IsNullOrEmpty(Password) || Password.Length < 8)
            {
                PasswordErrorMessege = "Password must have at least 8 letters";
                PasswordErrorMessegeIsVisible = true;
            }
            else
            {
                PasswordErrorMessege = "";
                PasswordErrorMessegeIsVisible = false;
            }
        }
        #endregion
        public ICommand SubmitCommand { get; set; }

        
    }
}
