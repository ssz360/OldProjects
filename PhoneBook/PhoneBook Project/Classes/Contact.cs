using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PhoneBook_Project.Enums;
using System.Collections;

namespace PhoneBook_Project.Classes
{
    [Serializable]
    public class Contact:Person
    {
        string personGroup;
        string email;
        string comment;
        long phoneNumber;
        ContactGroup contactGroup;
        Image contactPicture;
        ArrayList history;

        #region Constractors
        public Contact(string FirstName,string LastName,DateTime BirthDate,string PersonGroup, long Number, ContactGroup ContactGroup, string Email, string Comment,Image ContactPicture):base(FirstName,LastName,BirthDate)
        {
            this.personGroup = PersonGroup;
            this.phoneNumber = Number;
            this.email = Email;
            this.comment = Comment;
            this.contactGroup = ContactGroup;
            this.contactPicture = ContactPicture;
            history = new ArrayList();
        }
        public Contact()
            : base()
        { }
        #endregion

        #region methods

        public void AddHistory(History Input)
        {
            history.Add((object)Input);
        }

        public override string ToString()
        {
            return "First name"+this.FirstName + "\r\nLastName" + this.LastName + "\r\nPhonenumber:" + this.PhoneNumber;
        }

        #endregion

        #region Peraperties

        public string PersonGroup { get { return personGroup; } set { personGroup = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Comment { get { return comment; } set { comment = value; } }
        public long PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public ContactGroup ContactGroup { get { return contactGroup; } set { contactGroup = value; } }
        public Image ContactPicture { get { return contactPicture; } set { contactPicture = value; } }
        public ArrayList History { get { return history; } set { history = value; } }
        #endregion

    }
    
}
