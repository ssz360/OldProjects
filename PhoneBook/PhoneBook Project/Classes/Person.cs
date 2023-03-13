using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_Project.Classes
{
    [Serializable]
    public class Person
    {
        string firstName;
        string lastName;
        DateTime birthDate;

        #region Constractors
        public Person(string FirstName, string LastName, DateTime BirthDate)
        {
            firstName = FirstName;
            lastName = LastName;
            birthDate = BirthDate;
        }
        public Person()
        { }
        #endregion

        #region Properties
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }
        #endregion
    }
}
