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
    class HomePage : IConsolePage
    {

        public ConsoleColor Color { get; set; } = ConsoleColor.White;
        public PageHeader Header { get; set; } = PageHeader.ToolboxHeader;

        public void Run()
        {
            ConsoleUtils.WriteLine("Welcome to the MrQ toolbox!");
            bool answer = ConsoleUtils.AskYesNo("Do you want to open the help page?", true);
            if (answer)
            {
                PageController.ShowPage(Page.HelpPage);
            }
            else
            {
                ConsoleUtils.WriteLine("You decided not to open the help page!", ConsoleColor.Red);
                Console.ReadKey();
            }


        }
    }
}
