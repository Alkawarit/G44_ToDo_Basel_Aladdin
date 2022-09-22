using G44_ToDo_Basel_Aladdin.Data;
using G44_ToDo_Basel_Aladdin.Models;

namespace G44_ToDo_Basel_Aladdin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoService toDoService = new ToDoService();

            foreach (ToDo td in toDoService.FindAllTasks())
            {
                Console.WriteLine("From the PROGRAM.CS: " + td.Descriptiion);
            }



            toDoService.RemoveObjectFromToDoArray(3);
        }
    }
    }
