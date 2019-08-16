using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrQ_toolbox.Interfaces
{
    public interface IConsoleCommand
    {
        IConsoleCommand Parent { get; set; }
        string Format { get; }
        string Usage { get; }
        
        void Run(string[] args);
        
    }
}
