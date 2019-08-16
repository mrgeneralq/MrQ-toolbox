using MrQ_toolbox.Controllers;
using MrQ_toolbox.Enums;
using MrQ_toolbox.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrQ_toolbox.Mappers
{
    public class HeaderMapper
    {
        public static void Run()
        {

            // map all headers
            HeaderController.MapHeader(PageHeader.ToolboxHeader, new ToolboxHeader());
            
        }
    }
}
