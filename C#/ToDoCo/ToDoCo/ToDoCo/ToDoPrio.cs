using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoCo
{ 
    class ToDoPrio : ToDoEntry
    {


        private int inputInHours;

        public int InputInHours
        {
            get { return inputInHours; }
            set { inputInHours = value; }
        }

        public ToDoPrio(string title, string description, bool isDone, Guid id, int inputInHours, string priority) : base(title, description, isDone, id)
        {
            InputInHours = inputInHours;
        }

        // hier weiter
        public override string ToString()
        {
            return $"{Title,-20} {Description,-40}";
        }

    }
}
