using G44_ToDo_Basel_Aladdin.Data;
using G44_ToDo_Basel_Aladdin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Basel_Aladdin_Alexis_Test.Data
{
    public class PeopleServiceTest
    {

        [Fact]
        public void TestSize()
        {
            //Arrange
            PeopleService peopleService = new PeopleService();
            int expected = 3;
            //Act
           int result = peopleService.Size();
            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestFindAllPerson()
        {
            //Arrange
            Person[] expcted = { new Person(1,"Basel", "Askar"), new Person(2,"Alexis", "Caput"), new Person(3,"Aladdin", "Alkawarit") };
            //Act
            PeopleService peopleService = new PeopleService();
            Person[] result = peopleService.FindAllPerson();
            //Assert
            Assert.Equal(expcted.Length,result.Length);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.Equal(expcted[i].FirstName, result[i].FirstName);
                Assert.Equal(expcted[i].LastName, result[i].LastName);
            }
        }

        [Fact]
        public void TestFindByIdPerson()
        {
            //Arrange
            PeopleService peopleService = new PeopleService();
            //Person expected = peopleService.FindAllPerson()[0];

            Person expected = new Person(1, "Basel", "Askar");

            //Act
            Person? result = peopleService.FindByIdPerson(1);
            //Assert
            // Assert.Equal(expected, result);
            Assert.Equal(expected.Id, result.Id);
            Assert.Equal(expected.FirstName, result.FirstName);
            Assert.Equal(expected.LastName, result.LastName);
        }

        [Fact]
        public void TestFindByIdPersonOutOfTheRange()
        {
            PeopleService personService = new PeopleService();
            Person expected = null;
            Person result = personService.FindByIdPerson(4);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAddPerson()
        {
            //Arrange
            //Person person = new Person("Åsa", "Jonsson");
            Person[] expected = { new Person( "Basel", "Askar"),
                                  new Person( "Alexis", "Caput"),
                                  new Person( "Aladdin", "Alkawarit"),
                                  new Person( "Åsa", "Jonsson") };

            Person addedPerson = expected[expected.Length - 1];

            //Act
            PeopleService peopleService = new PeopleService();
            Person result = peopleService.AddPerson("Åsa", "Jonsson");

            //Assert
            Assert.Equal(addedPerson.FirstName,result.FirstName);
            Assert.Equal(addedPerson.LastName,result.LastName);
            Assert.Equal(expected.Length, peopleService.FindAllPerson().Length);


        }
        [Fact]
        public void TestClear()
        {
            //Arrange
            Person[] expected = new Person[0];
            //Act
            PeopleService personService = new PeopleService();
            personService.Clear();
            //Assert
            Assert.Equal(expected, personService.FindAllPerson());
        }

        [Fact]

        public void TestRemoveObjectFromPeopleArray()
        {
            //Arrange
            int expected = 2;
            //Act
            PeopleService personService = new PeopleService();
            Person[] result = personService.RemoveObjectFromPeopleArray(1);

            bool isAlexisExisted = result.Any(p => p.FirstName == "Alexis");

            //Assert
            Assert.Equal(expected, result.Length);
            Assert.False(isAlexisExisted);
        }
    }
}

