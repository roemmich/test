using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoCo
{
    /// <summary>
    /// Verwaltung der gesamten Liste
    /// </summary>
    class ToDoList
    {
        /// <summary>
        /// Liste mit allen Einträgen der ToDo-Liste
        /// </summary>
        public List<ToDoEntry> Items { get; set; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="path">Pfad zur csv-Datei, in der die ToDo-Items gespeichert werden</param>
        public ToDoList(string path)
        {
            Items = new List<ToDoEntry>();
            InitFromFile(path);
        }

        private void InitFromFile(string path)
        {
            CSVReader reader = new CSVReader(path, false);

            foreach (var line in reader.ParseFile())
            {
                Items.Add(new ToDoEntry(line[1], line[2], bool.Parse(line[3]), Guid.Parse(line[4])));
            }
        }
    }
}
