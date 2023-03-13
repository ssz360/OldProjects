using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook_Project.Enums;

namespace PhoneBook_Project.Classes
{
    public class History
    {
        DateTime _date;
        TimeSpan _callDuration;
        HistoryCallOrSms _smsOrCall;
        HistoryResiveOrDialed _resiveOrDialed;
        Contact _dialed;



        #region Constractors
        public History(HistoryCallOrSms CallOrSms, HistoryResiveOrDialed ResiveOrDialed, TimeSpan CallDuration, DateTime Date,Contact DialedContact)
        {
            _date = Date;
            _callDuration = CallDuration;
            _smsOrCall = CallOrSms;
            _resiveOrDialed = ResiveOrDialed;
            _dialed = DialedContact;

        }

        public History()
        { }

        #endregion


        #region Properties
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public TimeSpan CallDuration
        {
            get { return _callDuration; }
            set { _callDuration = value; }
        }

        public HistoryCallOrSms CallORSms
        {
            get { return _smsOrCall; }
            set { _smsOrCall = value; }
        }

        public HistoryResiveOrDialed ResiveOrDialed
        {
            get { return _resiveOrDialed; }
            set { _resiveOrDialed = value; }
        }
        public Contact DialedContact 
        { 
            get 
            { return _dialed; 
            } 
            set
            { 
                _dialed = value;
            }
        }
        #endregion


    }
}
