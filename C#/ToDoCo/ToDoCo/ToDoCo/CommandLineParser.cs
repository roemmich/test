using System;
using System.Collections.Generic;


namespace ToDoCo
{
    class CommandLineParser
    {
        /// <summary>
        /// Dictionary: key-value-Paar, key: Option, value: Enum-Befehl.
        /// </summary>
        public Dictionary<string, Commands> AllowedParams = new Dictionary<string, Commands>
        {
            { "-l" , Commands.LIST },
            { "-a" , Commands.ADD_ITEM },
            { "-r" , Commands.REMOVE },
            { "-t" , Commands.ADD_TERMIN },
            { "-p" , Commands.ADD_PRIO }
        };

        public string FileName { get; private set; }
        public Commands SelectedCommand { get; private set; }
        public List<string> OptionalArguments { get; private set; }
        /// <summary>
        /// Zeigt an, ob optionale Argumente vorhanden sind.
        /// </summary>
        public bool HasArguments
        {
            get
            {
                return OptionalArguments != null && OptionalArguments.Count > 0;
            }
        }

        public CommandLineParser(string[] args)
        {
            try
            {
                // Dateinamepfad ist das erste Argument
                FileName = args[0];
                // Selected Command: Enum-Eintrag aus AllowedParams
                SelectedCommand = AllowedParams[args[1]];

                if (args.Length > 2)
                {
                    OptionalArguments = new List<string>();
                    for (int i = 1; i < args.Length; ++i)
                    {
                        OptionalArguments.Add(args[i]);
                    }
                }
            }
            catch (KeyNotFoundException)
            {
                throw new UnknownCommandException(args[0]);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new CommandMissingException();
            }
        }
    }
}
