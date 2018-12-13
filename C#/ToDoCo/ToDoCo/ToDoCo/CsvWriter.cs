using System.IO;
using System.Text;

namespace ToDoCo
{
    class CSVWriter
    {

        private string filePath;

        public string FilePath
        {
            get { return filePath; }
        }

        public CSVWriter(string filePath)
        {
            this.filePath = filePath;
        }

        public void Write(ToDoEntry newEntry)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }
            else
            {
                StringBuilder entryBuilder = new StringBuilder();
                entryBuilder.Append(FormatEntry(newEntry.Title, true));
                entryBuilder.Append(FormatEntry(newEntry.Description));
                entryBuilder.Append(FormatEntry(newEntry.IsDone.ToString().ToLower()));
                entryBuilder.Append(FormatEntry(newEntry.ID.ToString(),false,true));
                File.AppendAllText(FilePath, entryBuilder.ToString());
            }
        }

        private string FormatEntry(string entry, bool isFirst = false, bool isLast = false)
        {
            if(isFirst)
            {
                return $"\nToDoEntry,\"{entry}\",";
            }
            else if(isLast)
            {
                return $"\"{entry}\"";
            }
            else
            {
                return $"\"{entry}\",";
            }
        }

    }
}
