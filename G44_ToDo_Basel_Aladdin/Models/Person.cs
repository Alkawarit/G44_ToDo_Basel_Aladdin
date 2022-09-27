using G44_ToDo_Basel_Aladdin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G44_ToDo_Basel_Aladdin.Models
{
    public class Person
    {
        private readonly int id;
        private string _firstName;
        private string _lastName;
        public int Id { get { return id; } }
        public string FirstName { get { return _firstName; } set  { _firstName = value; } }
        public string LastName { get { return _lastName; }  set { _lastName = value; } }

        public Person( string firstName, string lastName) 
        {
            this.id = PersonSequencer.NextPersonId();
            FirstName = firstName;
            LastName = lastName;
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(int id,string firstName,string lastName)
        {
            this.id=id;
            this._firstName = firstName;
            this._lastName = lastName;
        }

    }
}
