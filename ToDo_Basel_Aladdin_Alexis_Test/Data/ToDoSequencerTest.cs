using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G44_ToDo_Basel_Aladdin.Data;

namespace ToDo_Basel_Aladdin_Alexis_Test.Data
{
    public class ToDoSequencerTest
    {
        [Fact]
        public void NextToDoId()
        {
            ToDoSequencer.NextToDoId();

            //Arrange
            int Expected = 2;
            //Act
            int result = ToDoSequencer.NextToDoId();
            //Assert
            Assert.Equal(Expected, result);
        }

        [Fact]

        public void TestReSet()
        {
            ToDoSequencer.NextToDoId();
            ToDoSequencer.NextToDoId();
            ToDoSequencer.NextToDoId();
            ToDoSequencer.ReSet();
            //Arrange
            int expected = 0;
            //Act
            int result = ToDoSequencer.ToDoId;
            //Assert
            Assert.Equal(expected, result);
        }

    }
}
