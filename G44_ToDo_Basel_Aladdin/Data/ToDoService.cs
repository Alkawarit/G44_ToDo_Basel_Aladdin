using G44_ToDo_Basel_Aladdin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G44_ToDo_Basel_Aladdin.Data
{
    internal class ToDoService
    {

        private static ToDo[] tasks = { new ToDo("C#", true, new Person("Basel", "Askar")), new ToDo("SQL", false, new Person("Alexis", "Capot")), new ToDo("Java", true, new Person("Aladdin", "Alkawarit")) };

        public static int Size()
        {

            return tasks.Length;
        }

        public static ToDo[] FindAllTasks()
        {
            return tasks;
        }

        public ToDo? FindByIdTasks(int id)
        {
            foreach (ToDo task in tasks)
            {
                if (task.Id == id)
                    return task;

            }
            return null;
        }


        public ToDo AddTask(string discreption, bool done, Person assignee)
        {
            ToDo task = new ToDo(discreption, done, assignee);


            List<ToDo> newTask = tasks.ToList();

            newTask.Add(task);

            ToDo[] oldTask = newTask.ToArray();

            tasks = oldTask;

            return task;

        }


            public void Clear()
        {
            tasks = new ToDo[0];
        }



        // 10--add method
        public ToDo[]? FindByDoneStatus(bool doneStatus)  // Returns array with objects that has a matching done status.
        {
            ToDo[] tasksDone = new ToDo[tasks.Length];
            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i].Done)
                    tasksDone[i] = tasks[i];
            }
            return tasksDone;
        }
        public ToDo[] FindByAssignee(int personId) // Returns array with ToDo´s that has an assignee with a matching id.
        {
            ToDo[] tasksByPersonId = new ToDo[tasks.Length];
            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i].Assignee.Id == personId)
                    tasksByPersonId[i] = tasks[i];
            }
            return tasksByPersonId;
        }
        public ToDo[] FindByAssignee(Person assignee) // Returns array with ToDo´s that has this Person as its assignee.
        {
            ToDo[] tasksByPerson = new ToDo[tasks.Length];
            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i].Assignee.Id == assignee.Id)
                    tasksByPerson[i] = tasks[i];
            }
            return tasksByPerson;
        }
        public ToDo[] FindUnassignedTodoItems() // Returns an array of ToDo´s that does not have an assignee set to it.
        {
            ToDo[] unassignedTodoItems = new ToDo[tasks.Length];
            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i].Assignee.Id == null)
                    unassignedTodoItems[i] = tasks[i];
            }
            return unassignedTodoItems;
        }



        public void RemoveObjectFromToDoArray(int indexOfTheToDo)
        {
            int indexToRemove = -1;
            Console.WriteLine("Size Tasks before RemoveObjectFromToDoArray(1): " + tasks.Length);
            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i].Assignee.Id == indexOfTheToDo)
                {
                    indexToRemove = i;
                    tasks = tasks.Where((source, index) => index != i).ToArray();
                    //break;
                }
            }



            Console.WriteLine("Size Tasks after RemoveObjectFromToDoArray(1): " + tasks.Length);
            foreach (ToDo td in tasks)
            {
                Console.WriteLine("From the service: " + td.Descriptiion);
            }



        }

    }
}
