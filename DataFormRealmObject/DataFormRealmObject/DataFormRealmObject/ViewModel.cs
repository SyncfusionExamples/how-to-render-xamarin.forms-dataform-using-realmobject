using Realms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace DataFormRealmObject
{
    public class ViewModel: INotifyPropertyChanged
    {
        private ContactInfo contact;
        public ViewModel()
        {
            contact = new ContactInfo();
            var realm = Realm.GetInstance();

            realm.Write(() =>
            {
                var contactin = realm.Add<ContactInfo>(contact, true);
                contactin.Name = "Rex";
                contactin.Email = "rex@hotmail.com";
                contactin.ContactNumber = "199-1234";
                contactin.Address = "Sout cross street";
                contactin.BirthDate = new DateTime(1996, 04, 13);
                contactin.BirthTime = new DateTime(1996, 04, 13, 12, 12, 12);
            });

        }
       
    public ContactInfo Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }


}
