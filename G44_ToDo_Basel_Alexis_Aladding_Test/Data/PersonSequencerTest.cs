using G44_ToDo_Basel_Aladdin.Data;
using G44_ToDo_Basel_Aladdin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G44_ToDo_Basel_Alexis_Aladding_Test.Data
{
    public class PersonSequencerTest
    {

        [Fact]
        public void NextPersonId_Test()
        {
            int idExpected1 = 1;
            int idExpected2 = 2;
            int idExpected3 = 3;


            Person basel = new Person("Basel", "Askar");
            Person alaa = new Person("Alaa Aldeen", "Alkawarit");
            Person alexis = new Person("Alexis", "Capot");


            Assert.Equal(basel.Id, idExpected1);
            Assert.Equal(alaa.Id,idExpected2);
            Assert.Equal(alexis.Id,idExpected3);

            Assert.Equal(PersonSequencer.PersonId, idExpected3);

        }


        [Fact]
        public void ResetPersonId_Test()
        {
            int expected = 0;

            Person basel = new Person("Basel", "Askar");
            Person alaa = new Person("Alaa Aldeen", "Alkawarit");
            Person alexis = new Person("Alexis", "Capot");

            PersonSequencer.ReSet();

            int actualId = PersonSequencer.PersonId;

            Assert.Equal(expected, actualId);
        }
    }
}
