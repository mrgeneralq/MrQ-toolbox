using MrQ_toolbox.Enums;
using MrQ_toolbox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrQ_toolbox.Headers
{
    class ToolboxHeader : IPageHeader
    {
        public string Content { get; set; } =
"███╗   ███╗██████╗      ██████╗     ████████╗ ██████╗  ██████╗ ██╗     ██████╗  ██████╗ ██╗  ██╗\n" +
"████╗ ████║██╔══██╗    ██╔═══██╗    ╚══██╔══╝██╔═══██╗██╔═══██╗██║     ██╔══██╗██╔═══██╗╚██╗██╔╝\n" +
"██╔████╔██║██████╔╝    ██║   ██║       ██║   ██║   ██║██║   ██║██║     ██████╔╝██║   ██║ ╚███╔╝\n" +
"██║╚██╔╝██║██╔══██╗    ██║▄▄ ██║       ██║   ██║   ██║██║   ██║██║     ██╔══██╗██║   ██║ ██╔██╗\n" +
"██║ ╚═╝ ██║██║  ██║    ╚██████╔╝       ██║   ╚██████╔╝╚██████╔╝███████╗██████╔╝╚██████╔╝██╔╝ ██╗\n" +
"╚═╝     ╚═╝╚═╝  ╚═╝     ╚══▀▀═╝        ╚═╝    ╚═════╝  ╚═════╝ ╚══════╝╚═════╝  ╚═════╝ ╚═╝  ╚═╝\n";

        public ConsoleColor Color { get; set; } = ConsoleColor.Cyan;

    }
}
