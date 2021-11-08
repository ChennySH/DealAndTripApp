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
        #region UserName
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
        private string userNameErrorMessege;
        public string UserNameErrorMessege
        {
            get
            {
                return userNameErrorMessege;
            }
            set
            {
                if(userNameErrorMessege != value)
                {
                    userNameErrorMessege = value;
                    OnPropertyChanged();
                }
            }   
        }
        private bool userNameErrorMessegeIsVisible;
        public bool UserNameErrorMessegeIsVisible
        {
            get
            {
                return userNameErrorMessegeIsVisible;
            }
            set
            {
                if (userNameErrorMessegeIsVisible != value)
                {
                    userNameErrorMessegeIsVisible = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #region FirstName
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
        private string firstNameErrorMessege;
        public string FirstNameErrorMessege
        {
            get
            {
                return firstNameErrorMessege;
            }
            set
            {
                if (firstNameErrorMessege != value)
                {
                    firstNameErrorMessege = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool firstNameErrorMessegeIsVisible;
        public bool FirstNameErrorMessegeIsVisible
        {
            get
            {
                return firstNameErrorMessegeIsVisible;
            }
            set
            {
                if (firstNameErrorMessegeIsVisible != value)
                {
                    firstNameErrorMessegeIsVisible = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #region LastName
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
        private string lastNameErrorMessege;
        public string LastNameErrorMessege
        {
            get
            {
                return lastNameErrorMessege;
            }
            set
            {
                if (lastNameErrorMessege != value)
                {
                    lastNameErrorMessege = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool lastNameErrorMessegeIsVisible;
        public bool LastNameErrorMessegeIsVisible
        {
            get
            {
                return lastNameErrorMessegeIsVisible;
            }
            set
            {
                if (LastNameErrorMessegeIsVisible != value)
                {
                    LastNameErrorMessegeIsVisible = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #region Email
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
        private string emailErrorMessege;
        public string EmailErrorMessege
        {
            get
            {
                return emailErrorMessege;
            }
            set
            {
                if (emailErrorMessege != value)
                {
                    emailErrorMessege = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool emailErrorMessegeIsVisible;
        public bool EmailNameErrorMessegeIsVisible
        {
            get
            {
                return emailErrorMessegeIsVisible;
            }
            set
            {
                if (emailErrorMessegeIsVisible != value)
                {
                    emailErrorMessegeIsVisible = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #region Password
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
        #region RepeatPassword
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
        private string repeatPasswordErrorMessege;
        public string RepeatPasswordErrorMessege
        {
            get
            {
                return repeatPasswordErrorMessege;
            }
            set
            {
                if (repeatPasswordErrorMessege != value)
                {
                    repeatPasswordErrorMessege = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool repeatPasswordErrorMessegeIsVisible;
        public bool RepeatPasswordErrorMessegeIsVisible
        {
            get
            {
                return repeatPasswordErrorMessegeIsVisible;
            }
            set
            {
                if (repeatPasswordErrorMessegeIsVisible != value)
                {
                    repeatPasswordErrorMessegeIsVisible = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #region PhoneNumber
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
        private string phoneNumberErrorMessege;
        public string PhoneNumberErrorMessege
        {
            get
            {
                return phoneNumberErrorMessege;
            }
            set
            {
                if (phoneNumberErrorMessege != value)
                {
                    phoneNumberErrorMessege = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool phoneNumberErrorMessegeIsVisible;
        public bool PhoneNumberErrorMessegeIsVisible
        {
            get
            {
                return phoneNumberErrorMessegeIsVisible;
            }
            set
            {
                if (phoneNumberErrorMessegeIsVisible != value)
                {
                    phoneNumberErrorMessegeIsVisible = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #endregion
        #region ValdationMethods
        public bool ValidationAllValues()
        {
            return false;
        }
        public void UserNameValidation()
        {
            if (string.IsNullOrEmpty(UserName) || UserName.Length < 3)
            {
                UserNameErrorMessegeIsVisible = true;
            }
            else
                UserNameErrorMessegeIsVisible = false;
        }
        public void FirstNameValidation()
        {
            FirstNameErrorMessegeIsVisible = string.IsNullOrEmpty(FirstName);
        }
        public void LastNameValidation()
        {
            LastNameErrorMessegeIsVisible = string.IsNullOrEmpty(lastName);
        }
        public void PhoneNumberValidation()
        {
            if (string.IsNullOrEmpty(PhoneNumber))
            {
                PhoneNumberErrorMessegeIsVisible = true;
                return;
            }
            if (PhoneNumber.Length != 10)
            {
                PhoneNumberErrorMessegeIsVisible = true;
                return;
            }
            if (!PhoneNumber.StartsWith("05"))
            {
                PhoneNumberErrorMessegeIsVisible = true;
                return;
            }
            for (int i = 2; i < PhoneNumber.Length; i++)
            {
                char c = PhoneNumber[i];
                if (c < '0' || c > '9')
                {
                    PhoneNumberErrorMessegeIsVisible = true;
                    return;
                }
            }
            PhoneNumberErrorMessegeIsVisible = false;
        }
        #endregion
        public ICommand RegisterCommand { get; set; }
        
    }
}
