using System;
using System.Collections.Generic;
using System.Text;

namespace DealAndTripApp.ViewModels
{
    class SignUpPageViewModel : BaseViewModel
    {
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
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if(firstName != value)
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
                if(lastName != value)
                {
                    lastName = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
