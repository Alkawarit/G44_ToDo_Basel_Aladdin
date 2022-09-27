using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G44_ToDo_Basel_Aladdin.Data
{
    public class PersonSequencer
    {

        private static int personId;

        public static int PersonId { get { return personId; } }

        public static int NextPersonId()
        {
             personId++;
            return personId;
        }

        public static void ReSet()
        {
            personId = 0;
        }

    }
}
