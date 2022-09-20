using G44_ToDo_Basel_Aladdin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G44_ToDo_Basel_Aladdin.Data
{
    internal class PeopleService
    {

        private static Person[] persons = { new Person("Basel", "Askar"), new Person("Alexis", "Caput"), new Person("Aladdin", "Alkawarit") };

        public int Size() 
        { 

            return persons.Length; 
        }
        
        public  Person[] FindAllPerson()
        {
            return persons;
        }

        public Person FindByIdPerson(int id)
        {
            foreach(Person person in persons)
            {
                if (person.Id == id)
                    return person;

            }
            return null;
        }

        }

    }

