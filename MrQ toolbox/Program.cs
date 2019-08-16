using MrQ_toolbox.Controllers;
using MrQ_toolbox.Enums;
using MrQ_toolbox.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrQ_toolbox
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }

        void Run()
        {
            MainController.Run();
            PageController.ShowPage(Page.HomePage);
        }
    }
}
