using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G44_ToDo_Basel_Aladdin.Models
{
    internal class ToDo
    {
        private readonly int id;
        private string descriptiion;
        private bool done;
        private Person assignee;

        public int Id { get { return id; } }
        public string Descriptiion { get { return descriptiion; } set { descriptiion = value; } }
        public bool Done { get { return done; } set { done = value; } }
        public Person Assignee { get { return assignee; } set { assignee = value; } }
        public ToDo( int id, string description, bool done, Person assignee)
        {
            this.id = id;
            this.descriptiion = description;
            this.done = done;
            this.assignee = assignee;
        }
        {

        }

    }
}
