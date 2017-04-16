using Swaguin.Model;
using Swaguin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaguin.ViewModel
{
    public class ContactListViewModel : INotifyPropertyChanged
    {
        string firstName;
        string lastName;

        private ContactManager contactManager;
        public IList<ContactViewModel> Contacts { get; private set; }
        ContactViewModel selectedContact;

        public ContactListViewModel()
        {
            this.contactManager = new ContactManager();

            // Insert();
            // GetAllContact();


            this.firstName = "Samuel";
            //this.lastName = Contacts.First().LastName;

        }

        public async void GetAllContact()
        {
            IList<Contact> listContact = await contactManager.GetAllContactAsync();

            Contacts = new ObservableCollection<ContactViewModel>(listContact
                            .Select(q => new ContactViewModel(q)));
        }

        public async void Insert()
        {
            await contactManager.AddNewContactAsync("Samuel");
        }

        public ContactViewModel SelectedContact
        {
            get
            {
                return selectedContact;
            }
            set
            {
                selectedContact = value;
                OnPropertyChanged("selectedContact");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string FirstName
        {
            set
            {
                if (firstName != value)
                {
                    firstName = value;

                    OnPropertyChanged("FirstName");
                }
            }
            get
            {
                return firstName;
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
