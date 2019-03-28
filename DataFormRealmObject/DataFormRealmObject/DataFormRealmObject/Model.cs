using Realms;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFormRealmObject
{
    public class ContactInfo : RealmObject
    {
        public ContactInfo()
        {
        }

        public string Name { get; set; }

        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
        
        [Display(Name = "Birth Date")]
        public DateTimeOffset? BirthDate { get; set; }
    }
}

