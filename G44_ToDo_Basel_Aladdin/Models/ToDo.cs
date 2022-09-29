using G44_ToDo_Basel_Aladdin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G44_ToDo_Basel_Aladdin.Models
{
    public class ToDo
    {
        private readonly int id;
        private string descriptiion;
        private bool done;
        private Person assignee;

        public int Id { get { return id; } }
        public string Description {
            get { return descriptiion; } 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Description is not valid");
                }

                descriptiion = value; 
            } 
        }
        public bool Done { get { return done; } set { done = value; } }
        public Person Assignee { get { return assignee; } set { assignee = value; } }
        
        
        public ToDo(string description, bool done, Person assignee)
        {
            this.id = ToDoSequencer.NextToDoId();
            Description = description;
            Done = done;
            Assignee = assignee;
        }



        public ToDo(string description)
        {

            Description = description;
        }
        

    }

}

