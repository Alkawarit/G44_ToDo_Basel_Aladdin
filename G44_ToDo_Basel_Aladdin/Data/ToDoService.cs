using G44_ToDo_Basel_Aladdin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G44_ToDo_Basel_Aladdin.Data
{
    public class ToDoService
    {

        private static ToDo[] tasks = { new ToDo("C#", true, new Person("Basel", "Askar")),
                                        new ToDo("SQL", false, new Person("Alexis", "Capot")),
                                        new ToDo("Java", true, new Person("Aladdin", "Alkawarit")) };

        public int Size()
        {

            return tasks.Length;
        }

        public ToDo[] FindAllTasks()
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
            //ToDo[] tasksDone = new ToDo[tasks.Length];
            //for (int i = 0; i < tasks.Length; i++)
            //{
            //    if (tasks[i].Done)
            //        tasksDone[i] = tasks[i];
            //}
            //return tasksDone;
            //List<ToDo> doneTasks = new List<ToDo>();
            //foreach (ToDo task in tasks)
            //{
            //    if (task.Done) doneTasks.Add(task);
            //}
            //return doneTasks.ToArray();

            //int countTasksDone = 0;
            //foreach (ToDo toDo in tasks)
            //{
            //    if (toDo.Done) countTasksDone++;
            //}
            //ToDo[] tasksDone = new ToDo[countTasksDone];


            return tasks.Where(todo => todo.Done).ToArray();
        }
        public ToDo[] FindByAssignee(int personId) // Returns array with ToDo´s that has an assignee with a matching id.
        {
            //ToDo[] tasksByPersonId = new ToDo[tasks.Length];
            //for (int i = 0; i < tasks.Length; i++)
            //{
            //    if (tasks[i].Assignee.Id == personId)
            //        tasksByPersonId[i] = tasks[i];
            //}
            //return tasksByPersonId;



            //List<ToDo> personTasks = new List<ToDo>();
            //foreach (ToDo task in tasks)
            //{
            //    if (task.Assignee.Id == personId)
            //    {
            //        personTasks.Add(task);
            //    }
            //}
            //return personTasks.ToArray();

            return tasks.Where(todo => todo.Assignee.Id == personId).ToArray();

        }
        public ToDo[] FindByAssignee(Person assignee) // Returns array with ToDo´s that has this Person as its assignee.
        {
            //ToDo[] tasksByPerson = new ToDo[tasks.Length];
            //for (int i = 0; i<tasks.Length; i++)
            //{
            //    if (tasks[i].Assignee.Id == assignee.Id)
            //        tasksByPerson[i] = tasks[i];
            //}
            //return tasksByPerson;


            //List<ToDo> personTasks = new List<ToDo>();
            //foreach (ToDo toDo in tasks)
            //{
            //    if (toDo.Assignee.Id == assignee.Id)
            //    {
            //        personTasks.Add(toDo);
            //    }
            //}
            //return personTasks.ToArray();


            return tasks.Where(todo => todo.Assignee?.Id == assignee.Id).ToArray();
        }
        public ToDo[] FindUnassignedTodoItems() // Returns an array of ToDo´s that does not have an assignee set to it.
        {
            //ToDo[] unassignedTodoItems = new ToDo[tasks.Length];
            //for (int i = 0; i < tasks.Length; i++)
            //{
            //    if (tasks[i].Assignee.Id == null)
            //        unassignedTodoItems[i] = tasks[i];
            //}            
            //return unassignedTodoItems;

            //List<ToDo> unAssignedTasks = new List<ToDo>();
            //foreach (ToDo toDo in tasks)
            //{
            //    if (toDo.Assignee == null)
            //    {
            //        unAssignedTasks.Add(toDo);
            //    }
            //}
            //return unAssignedTasks.ToArray();

            return tasks.Where(todo => todo.Assignee != null).ToArray();
        }



       public ToDo[] RemoveObjectFromToDoArray(int indexOfTheToDo)
        {
            // Console.WriteLine("Size Tasks before RemoveObjectFromToDoArray(1): " + tasks.Length);



            //Console.WriteLine("Size Tasks after RemoveObjectFromToDoArray(1): " + tasks.Length);
            // foreach (ToDo td in tasks)
            // {
            //     Console.WriteLine("From the service: " + td.Descriptiion);
            // }

            // return tasks;

            //List<ToDo> newTasks = new List<ToDo>();
            //for (int i=0; i < tasks.Length; i++)
            //{
            //    if (i != indexOfTheToDo)
            //    {
            //        newTasks.Add(tasks[i]);
            //    }
            //}

            //tasks = newTasks.ToArray();
            //return tasks;

            tasks = tasks.Where((source, index) => index != indexOfTheToDo).ToArray();

            return tasks;
       }

    }
}
