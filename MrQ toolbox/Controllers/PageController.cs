using MrQ_toolbox.Enums;
using MrQ_toolbox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrQ_toolbox.Controllers
{
    class PageController
    {

        static Dictionary<Page, IConsolePage> pageMap = new Dictionary<Page, IConsolePage>();



        public static void ShowPage(Page pageObject)
        {
            Console.Clear();

            if (!pageMap.ContainsKey(pageObject))
                throw new Exception("Page is not mapped yet!");

            var page = pageMap[pageObject];

            // check if there is a header set, if there is, show the header first!
            if (HeaderController.ContainsHeader(page))
            {
                IPageHeader header = HeaderController.GetHeader(PageHeader.ToolboxHeader);
                Console.ForegroundColor = header.Color;
                Console.WriteLine(header.Content);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = page.Color;
            }

            page.Run();

        }

        public static void MapPage(Page page, IConsolePage consolePage)
        {
            if (pageMap.ContainsKey(page))
                throw new Exception("Page is already mapped!");
            pageMap.Add(page, consolePage);
        }

    }
}
