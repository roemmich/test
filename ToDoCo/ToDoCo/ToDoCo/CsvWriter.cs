using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoCo
{
    class CsvWriter
    {
        public void Write(ToDoEntry newEntry, string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }
            else
            {
                var entries = new string[] { newEntry.Title, newEntry.Description, newEntry.IsDone.ToString(),newEntry.ID.ToString() };
                foreach (var entryItem in entries)
                {
                    // In neue Zeile schreiben!
                    File.AppendAllText(filePath,entryItem);
                }
            }

        }
    }
}
