using System;
namespace Banking.CUI{
    public class ConsoleShell : IShell
    {
        public void WriteLine(string value) { Console.WriteLine(value); }
        public void Write(string value) { Console.Write(value); }
        public string ReadLine() { return Console.ReadLine(); }

    }
}