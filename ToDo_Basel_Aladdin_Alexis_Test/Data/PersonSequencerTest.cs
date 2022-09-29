using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using G44_ToDo_Basel_Aladdin.Models;
using G44_ToDo_Basel_Aladdin.Data;


namespace ToDo_Basel_Aladdin_Alexis_Test.Data
{
    public class PersonSequencerTest
    {
        [Fact]
        public void TestNextPersonId()
        {
            //PersonTest person1 = new PersonTest("Basel", "Askar");
            //PersonTest person2 = new PersonTest("Alexis", "Asskar");
            //PersonTest person3 = new PersonTest("Aladdin", "AlKawarit");


            PersonSequencer.NextPersonId();
            PersonSequencer.NextPersonId();
            //PersonSequencer.NextPersonId();


            //Arrange
            int expected = 3;
            //Act
            int result = PersonSequencer.NextPersonId();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
           public void TestReSet()
        {
            PersonSequencer.NextPersonId();
            PersonSequencer.NextPersonId();
            PersonSequencer.ReSet();
            // Arrange
            int expected = 0;
            //Act
            int result = PersonSequencer.PersonId;
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
