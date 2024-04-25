using System;

namespace Konstruktorerövning2inl
{
    class Program
    {
        static void Main(string[] args)
        {
            namn jag = new namn("alex", "ved");
            namn pappa = new namn("mag", "ved");
            Console.WriteLine(jag.getFullnamn());
        }
    }
}