using System;

namespace SolidPrinciples.SRP_Compliant
{
    public class ConsoleLogger : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }

        public void Error(string message)
        {
            Console.WriteLine($"❌ ERRO: {message}");
        }
    }
}