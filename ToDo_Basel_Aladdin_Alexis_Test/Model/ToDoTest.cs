using G44_ToDo_Basel_Aladdin.Data;
using G44_ToDo_Basel_Aladdin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Basel_Aladdin_Alexis_Test.Model
{
    public class ToDoTest
    {
        [Fact]
        public void TodoClassTest()
        {
            //Arrange
            string description1 = "Finish assignment";
            string description2 = "Go for walk";

            //Act
            ToDo testTodo1 = new ToDo(description1);
            ToDo testTodo2 = new ToDo(description2);

            //Assert

            Assert.Equal(description1,testTodo1.Description);
            Assert.Equal(description2, testTodo2.Description);


        }




        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Test_BadDescriptionForToDoClass(string description)
        {

            ToDo testToDo = new ToDo("Work");

            ArgumentException setDescriptionEx = Assert.Throws<ArgumentException>(() => testToDo.Description = description);

            Assert.Contains("Description", setDescriptionEx.Message);



            ArgumentException createToDoEx = Assert.Throws<ArgumentException>(() => new ToDo(description));

            Assert.Contains("Description", createToDoEx.Message);

        }
    }
}
