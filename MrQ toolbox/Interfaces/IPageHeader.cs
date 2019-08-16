using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrQ_toolbox.Interfaces
{
    public interface IPageHeader
    {
        string Content { get; set; }
        ConsoleColor Color { get; set; }
    }
}
