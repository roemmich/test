using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoCo
{
    class ToDoDate : ToDoEntry
    {
        public ToDoDate(string title, string description, bool isDone, Guid id) : base (title, description, isDone, id)
        {
            
        }
    }
}
