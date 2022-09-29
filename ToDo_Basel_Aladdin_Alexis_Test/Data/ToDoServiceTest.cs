using G44_ToDo_Basel_Aladdin.Data;
using G44_ToDo_Basel_Aladdin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Basel_Aladdin_Alexis_Test.Data
{
    public class ToDoServiceTest
    {

        [Fact]
        public void TestSize()
        {
            //Arrange
            ToDoService toDoService = new ToDoService();
            int expected = 3;
            //Act
            int result = toDoService.Size();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindAllTasksTest()
        {

            //Arrange

         ToDo[] expected = { new ToDo("C#", true, new Person("Basel", "Askar")),
                                        new ToDo("SQL", false, new Person("Alexis", "Capot")),
                                        new ToDo("Java", true, new Person("Aladdin", "Alkawarit")) };

           //Act
           ToDoService toDoService = new ToDoService();
            ToDo[] result = toDoService.FindAllTasks();
            //Assert
            Assert.Equal(expected.Length, result.Length);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.Equal(expected[i].Description, result[i].Description);
                Assert.Equal(expected[i].Done, result[i].Done);
               // Assert.Equal(expected[i].Assignee, result[i].Assignee);
            }
        }

        [Fact]
        public void FindByIdTasksTest()
        {
            //Arrange
            ToDoService toDoService = new ToDoService();

            ToDo expected = toDoService.FindAllTasks()[0];
            //Act
            ToDo? result = toDoService.FindByIdTasks(1);

            //Assert
            //Assert.Equal(expected.Description, result.Description);
            Assert.Equal(expected, result);
          
        }



        [Fact]
        public void TestAddTask()
        {
            //Arrange
            ToDo[] expected = { new ToDo("C#", true, new Person("Basel", "Askar")),
                                        new ToDo("SQL", false, new Person("Alexis", "Capot")),
                                        new ToDo("Java", true, new Person("Aladdin", "Alkawarit")),
                                        new ToDo ("Paython", false, null)};

            ToDo addTask = expected[expected.Length - 1];

            //Act
            ToDoService toDoService = new ToDoService();
            ToDo result = toDoService.AddTask("Paython", false, null);
            ToDo[] tasks = toDoService.FindAllTasks();

            bool isAddedTask = tasks.Any(t => t.Description == "Paython");

            //Assert
            Assert.Equal(addTask.Description, result.Description);
            Assert.Equal(addTask.Assignee, result.Assignee);

            Assert.Equal(expected.Length,toDoService.FindAllTasks().Length);
            Assert.True(isAddedTask);
           
        }

        [Fact]
        public void TestClear()
        {
            //Arrange
            int expected = 0;

            //Act
            ToDoService toDoService = new ToDoService();
            toDoService.Clear();

            //Assert
            Assert.Equal(expected, toDoService.FindAllTasks().Length);

        }

        [Fact]

        public void TestFindByDoneStatus()
        {
            //Arrange
            ToDo[] expected = { new ToDo("C#", true, new Person("Basel", "Askar")),
                                new ToDo("Java", true, new Person("Aladdin", "Alkawarit")) };

            //Act
            ToDoService toDoService = new ToDoService();
            ToDo[] result = toDoService.FindByDoneStatus(true);

            bool isAllStatusDone = result.All(t => t.Done);

            //Assert
            Assert.True(isAllStatusDone);
            Assert.Equal(expected.Length,result.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i].Description,result[i].Description);
            }
            
        }
    }
  } 

