using DealAndTripApp.Models;
using DealAndTripApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DealAndTripApp.ViewModels
{
    class SignUpPageViewModel : BaseViewModel
    {
        public SignUpPageViewModel()
        {
            userName = "";
            firstName = "";
            lastName = "";
            email = "";
            password = "";
            repeatPassword = "";
            phoneNumber = "";
            RegisterCommand = new Command(Register);
        }

        private async void Register()
        {
            DealAndTripAPIProxy proxy = DealAndTripAPIProxy.CreateProxy();
            try
            {
                if(repeatPassword != password)
                {
                    ErrorMessege = "Passwords are not matching";
                }
                else
                {
                    User newUser = new User
                    {
                        UserName = this.UserName,
                        FirstName = this.FirstName,
                        LastName = this.LastName,
                        Email = this.Email,
                        Password = this.Password,
                        PhoneNumber = this.PhoneNumber,
                    };
                    bool registered = await proxy.SignUpAsync(newUser);
                    if (registered)
                        ErrorMessege = "User created succesfully!";
                    else
                        ErrorMessege = "Something went wrong";
                }
            }
            catch (Exception)
            {
                ErrorMessege = "Something went wrong";
            }
        }
        #region properties
        private string errorMessege;
        public string ErrorMessege
        {
            get
            {
                return errorMessege;
            }
            set
            {
                if (errorMessege != value)
                {
                    errorMessege = value;
                    OnPropertyChanged();
                }
            }
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
                if (userName != value)
                {
                    userName = value;
                    OnPropertyChanged();
                }
            }
        }

        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    OnPropertyChanged();
                }
            }
        }
        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    OnPropertyChanged();
                }
            }
        }
        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (email != value)
                {
                    email = value;
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
                if(password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }
        private string repeatPassword;
        public string RepeatPassword
        {
            get
            {
                return repeatPassword;
            }
            set
            {
                if (repeatPassword != value)
                {
                    repeatPassword = value;
                    OnPropertyChanged();
                }
            }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (phoneNumber != value)
                {
                    phoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        public ICommand RegisterCommand { get; set; }
        
    }
}
