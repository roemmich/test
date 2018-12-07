using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoCo
{
    /// <summary>
    /// Klasse zur Verwaltung eines Eintrags der ToDo-Liste
    /// </summary>
    class ToDoEntry
    {
        /// <summary>
        /// Titel der Aufgabe
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Beschreibungstext für die Aufgabe
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gibt an, ob die Aufgabe erledigt ist
        /// </summary>
        public bool IsDone { get; set; }

        /// <summary>
        /// Eindeutige ID für diese Aufgabe
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// ctor für eine bestehende Aufgabe
        /// </summary>
        /// <param name="title">Titel</param>
        /// <param name="description">Beschreibung</param>
        /// <param name="isDone">Erledigt</param>
        /// <param name="id">ID</param>
        public ToDoEntry(string title, string description, bool isDone, Guid id)
        {
            InitClass(title, description, isDone, id);
        }

        private void InitClass(string title, string description, bool isDone, Guid id)
        {
            if(String.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException(title);
            }
            if (String.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentNullException(description);
            }

            Title = title;
            Description = description;
            IsDone = isDone;
            ID = id;
        }

        /// <summary>
        /// ctor für eine neu Aufgabe, ID wird automatisch ermittelt
        /// </summary>
        /// <param name="title">Titel</param>
        /// <param name="description">Beschreibung</param>
        public ToDoEntry(string title, string description)
        {
            InitClass(title, description, false, Guid.NewGuid());
        }

        public override string ToString()
        {
            return $"{Title,-20} {Description,-40}";
        }
    }
}
