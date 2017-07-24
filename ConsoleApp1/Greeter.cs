using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Greeter
    {
        protected String name;

        public void setName(String newName)
        {
            name = newName;
        }

        public String greet()
        {
            return "Hello " + name;
        }
    }
}
