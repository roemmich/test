using System;

namespace ToDoCo
{
    class Program
    {
        protected Program()
        {

        }

        static void Main(string[] args)
        {
            // Kommandozeilenargumente übergeben.             
            var cmdLineArgs = new CommandLineParser(args);
            // Neue ToDo-Liste erstellen.
            ToDoList list = new ToDoList(cmdLineArgs.FileName);

            switch (cmdLineArgs.SelectedCommand)
            {
                case Commands.LIST:
                    foreach (ToDoEntry entry in list.Items)
                    {
                        Console.WriteLine(entry);
                    }
                    break;
                case Commands.ADD_ITEM:
                    try
                    {
                        var newEntry = new ToDoEntry(cmdLineArgs.OptionalArguments[1], cmdLineArgs.OptionalArguments[2]);
                        list.Items.Add(newEntry);
                        CSVWriter cs = new CSVWriter(cmdLineArgs.FileName);
                        cs.Write(newEntry);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(cmdLineArgs.FileName);
                        Console.WriteLine(e.Message);
                    }
                    break;
                case Commands.CLOSE:
                    throw new NotImplementedException();
                case Commands.REMOVE:
                    throw new NotImplementedException();
                case Commands.ADD_TERMIN:
                    throw new NotImplementedException();
                case Commands.ADD_PRIO:
                    throw new NotImplementedException();
            }
           
        }
    }
}
