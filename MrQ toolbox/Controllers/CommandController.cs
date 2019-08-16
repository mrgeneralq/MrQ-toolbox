using MrQ_toolbox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrQ_toolbox.Controllers
{

    public class CommandController
    {

        public static Dictionary<string, IConsoleCommand> commandMap = new Dictionary<string, IConsoleCommand>();


        public static void MapCommand(string cmdLabel, IConsoleCommand command)
        {
            if (commandMap.ContainsKey(cmdLabel))
                throw new Exception(String.Format("Command:'{0}' is already mapped!", cmdLabel));

            commandMap.Add(cmdLabel, command);
        }

        public static IConsoleCommand GetCommand(string cmd)
        {
            if (!commandMap.ContainsKey(cmd))
                throw new Exception(String.Format("Command:'{0}' not found in commandmap!", cmd));

            return commandMap[cmd];
           
        }

        public static void RunCommand(string cmd)
        {
            IConsoleCommand command = GetCommand(cmd);
         //   command.Run(cmd);

        }





    }
}
