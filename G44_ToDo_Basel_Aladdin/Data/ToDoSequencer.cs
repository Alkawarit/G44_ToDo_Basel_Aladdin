using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G44_ToDo_Basel_Aladdin.Data
{
    public class ToDoSequencer
    {

        private static int toDoId;

        public static int ToDoId { get { return toDoId; } }

        public static int NextToDoId()
        {
            toDoId++;
            return toDoId;
        }

        public static void ReSet()
        {
            toDoId = 0;
        }
    }
}
