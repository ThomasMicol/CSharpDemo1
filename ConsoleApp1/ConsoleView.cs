using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ConsoleView : IView
    {
        public void start()
        {
            Console.Clear();
        }

        public void stop()
        {
            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }

        public String getString(String prompt = "")
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public Int16 getInt(String prompt = "")
        {
            Console.WriteLine(prompt);
            return Int16.Parse(Console.ReadLine());

        }

        public void show<T>(T message)
        {
            Console.WriteLine(message);
        }
    }
}