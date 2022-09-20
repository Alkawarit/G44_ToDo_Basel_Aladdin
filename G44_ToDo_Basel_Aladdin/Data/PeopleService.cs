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

        public Person? FindByIdPerson(int id)
        {
            foreach(Person person in persons)
            {
                if (person.Id == id)
                    return person;

            }
            return null;
        }



        public Person AddPerson(string firstName,string lastName)
        {
            Person person = new Person(firstName, lastName);

            //Person[] newPeople = new Person[persons.Length + 1];

            //for (int i=0; i < persons.Length; i++)
            //{
            //    newPeople[i] = persons[i];
            //}

            //newPeople[persons.Length] = person;

            //persons = newPeople;

            //return person;



            List<Person> newPeople = persons.ToList();

            newPeople.Add(person);

            Person[] people = newPeople.ToArray();

            persons = people;

            return person;


        }



    }

}

