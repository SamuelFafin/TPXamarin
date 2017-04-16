using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swaguin.Models;
using System.ComponentModel;

namespace Swaguin.ViewModel
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        readonly Contact contact;
        public event PropertyChangedEventHandler PropertyChanged;

        public ContactViewModel(Contact contact)
        {
            this.contact = contact;
        }

        public ContactViewModel()
            : this(new Contact())
        {
            FirstName = "Toto";
            LastName = "Tata";
            Gender = Gender.Male;
            Favorite = false;
            
        }

        public string FirstName
        {
            set
            {
                if (contact.FirstName != value)
                {
                    contact.FirstName = value;

                    OnPropertyChanged("FirstName");
                }
            }
            get
            {
                return contact.FirstName;
            }
        }

        public string LastName
        {
            set
            {
                if (contact.LastName != value)
                {
                    contact.LastName = value;

                    OnPropertyChanged("LastName");
                }
            }
            get
            {
                return contact.LastName;
            }
        }

        public string Email
        {
            set
            {
                if (contact.Email != value)
                {
                    contact.Email = value;

                    OnPropertyChanged("Email");
                }
            }
            get
            {
                return contact.Email;
            }
        }

        public string ImagePath
        {
            set
            {
                if (contact.ImagePath != value)
                {
                    contact.ImagePath = value;

                    OnPropertyChanged("ImagePath");
                }
            }
            get
            {
                return contact.ImagePath;
            }
        }

        public string PhoneNumber
        {
            set
            {
                if (contact.PhoneNumber != value)
                {
                    contact.PhoneNumber = value;

                    OnPropertyChanged("PhoneNumber");
                }
            }
            get
            {
                return contact.PhoneNumber;
            }
        }

        public DateTime Birthdate
        {
            set
            {
                if (contact.Birthdate != value)
                {
                    contact.Birthdate = value;

                    OnPropertyChanged("Birthdate");
                }
            }
            get
            {
                return contact.Birthdate;
            }
        }

        public bool Favorite
        {
            set
            {
                if (contact.Favorite != value)
                {
                    contact.Favorite = value;

                    OnPropertyChanged("Favorite");
                }
            }
            get
            {
                return contact.Favorite;
            }
        }

        public Gender Gender
        {
            set
            {
                if (contact.Gender != value)
                {
                    contact.Gender = value;

                    OnPropertyChanged("Favorite");
                }
            }
            get
            {
                return contact.Gender;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
