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

        private static ToDo[] tasks = { new ToDo("C#", true, new Person("Basel", "Askar")), new ToDo("SQL", false, new Person("Alexis", "Capot") ), new ToDo("Java", true, new Person("Aladdin", "Alkawarit") ) };

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

            public void Clear()
            {
                tasks = new ToDo[0];
            }

        }
    }
