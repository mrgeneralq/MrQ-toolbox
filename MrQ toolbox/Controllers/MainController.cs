using MrQ_toolbox.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrQ_toolbox.Controllers
{
    class MainController
    {
        public static void Run()
        {
            PageMapper.Run();
            HeaderMapper.Run();
        }
    }
}
