using MrQ_toolbox.Controllers;
using MrQ_toolbox.Enums;
using MrQ_toolbox.Interfaces;
using MrQ_toolbox.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrQ_toolbox.Mappers
{
    public class PageMapper
    {
        public static void Run()
        {
            // map all pages
            PageController.MapPage(Page.HomePage, new HomePage());
            PageController.MapPage(Page.HelpPage, new HelpPage());

        }
    }
}
