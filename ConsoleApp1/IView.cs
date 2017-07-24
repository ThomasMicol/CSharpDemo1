using System;

namespace ConsoleApp1
{
    internal interface IView
    {
        void Start();
        void Stop();
        string GetStarted(string prompt);
        Int16 getInt(string prompt);
        void Show<T>(T message);


    }
}