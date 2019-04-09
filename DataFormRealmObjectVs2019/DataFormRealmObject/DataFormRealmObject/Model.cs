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

        //[Display(Name = "Birth Date")]
        //public DateTime BirthDate { get; set; }
        private DateTimeOffset displayDate;

        [Converter(typeof(ValueConverterExt))]
        public DateTimeOffset DisplayDate
        {
            get
            {
                return displayDate;
            }
            set
            {
                displayDate = value;
            }
        }



    }

    public class ValueConverterExt : IPropertyValueConverter
    {
        public object Convert(object value)
        {
            DateTime baseTime = new DateTime(2008, 6, 19, 7, 0, 0);
            DateTime targetTime;

            var dateTimeOffset = (DateTimeOffset)value;
            dateTimeOffset = new DateTimeOffset(baseTime,
                                                TimeZoneInfo.Local.GetUtcOffset(baseTime));
            targetTime = dateTimeOffset.DateTime;
            return targetTime;
        }
        public object ConvertBack(object value)
        {
            var dateTime = (DateTime)value;
            dateTime = new DateTime(2008, 6, 19, 7, 0, 0);
            dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Local);
            DateTimeOffset dateTimeOffset = dateTime;
            return dateTimeOffset;
        }
    }
}

