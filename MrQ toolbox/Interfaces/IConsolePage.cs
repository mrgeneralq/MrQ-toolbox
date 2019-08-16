using MrQ_toolbox.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrQ_toolbox.Interfaces
{
    public interface IConsolePage
    {

        PageHeader Header { get; set; }
        ConsoleColor Color { get; set; }

        void Run();
    }
}
