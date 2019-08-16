using MrQ_toolbox.Enums;
using MrQ_toolbox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrQ_toolbox.Controllers
{
    public class HeaderController
    {

        private static Dictionary<PageHeader, IPageHeader> headerMap = new Dictionary<PageHeader, IPageHeader>();

        
        public static void MapHeader(PageHeader header, IPageHeader headerInterface)
        {
            if (headerMap.ContainsKey(header))
                throw new Exception("This header is already mapped!");

            headerMap.Add(header, headerInterface);
        }

        public static IPageHeader GetHeader(PageHeader header)
        {
            if (!headerMap.ContainsKey(header))
                throw new Exception("Header not mapped!");

            return headerMap[header];
        }


        public static bool ContainsHeader(IConsolePage page)
        {
            return Enum.IsDefined(typeof(PageHeader),page.Header);
        }
    }
}
