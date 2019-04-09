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

        private DateTime? birthDate;

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }
        private DateTime? birthTime;

        [Display(Name = "Birth Time")]
        [DataType(DataType.Time)]
        public DateTime? BirthTime
        {
            get
            {
                return birthTime;
            }
            set
            {
                birthTime = value;
            }
        }
    }
}


