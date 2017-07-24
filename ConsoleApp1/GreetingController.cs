using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GreetingController
    {
        IView view;
        Greeter greeter;

        public GreetingController(IView theView, Greeter theGreeter)
        {
            view = theView;
            greeter = theGreeter;

        }
    }
}
