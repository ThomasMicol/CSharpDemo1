using System;

namespace ConsoleApp1
{
    internal interface IView
    {
        void start();
        void stop();
        string getString(string prompt);
        Int16 getInt(string prompt);
        void show<T>(T message);


    }
}