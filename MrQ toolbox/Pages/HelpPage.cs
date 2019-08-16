using MrQ_toolbox.Controllers;
using MrQ_toolbox.Enums;
using MrQ_toolbox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrQ_toolbox.Pages
{
    class HelpPage : IConsolePage
    {
        public PageHeader Header { get; set; } = PageHeader.ToolboxHeader;
        public ConsoleColor Color { get; set; } = ConsoleColor.White;

        public void Run()
        {
            ConsoleUtils.WriteLine("This is the help page!", ConsoleColor.DarkMagenta);
            Console.ReadKey();

        }
    }
}
