using G44_ToDo_Basel_Aladdin.Data;
using G44_ToDo_Basel_Aladdin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Basel_Aladdin_Alexis_Test.Model
{
    public class PersonTest
    {
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void FirstNameBadValueTest(string badFirstName)
        {
            //Arrange
            Person testPerson = new Person("Ã…sa", "Jonsson");

            //Act
            ArgumentException exception = Assert.Throws<ArgumentException>(() => testPerson.FirstName = badFirstName);

            //Assert
            Assert.Contains("FirstName", exception.Message);

        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void LastNameBadValueTest(string badLastName)
        {
            //Arrange
            Person testPerson = new Person("Sam", "Jonsson");

            //Act
            var exception = Assert.Throws<ArgumentException>(() => testPerson.LastName = badLastName);

            //Assert
            Assert.Contains("LastName", exception.Message);
        }

        [Fact]
        public void PersonClassTest()
        {
            // Arrange
            string firstName1 = "Sally";
            string lastName1 = "Corey";
            string firstName2 = "Mona";
            string lastName2 = "Carlesson";


            // Act
            Person testPerson1 = new Person(firstName1, lastName1);
            Person testPerson2 = new Person(firstName2, lastName2);

            // Assert        
            Assert.Equal(firstName1, testPerson1.FirstName);
            Assert.Equal(lastName1, testPerson1.LastName);
            Assert.Equal(firstName2, testPerson2.FirstName);
            Assert.Equal(lastName2, testPerson2.LastName);


        }
    }
}
