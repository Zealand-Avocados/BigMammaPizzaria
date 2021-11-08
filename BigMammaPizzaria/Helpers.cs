using System;

namespace BigMammaPizzaria
{
    public static class Helpers
    {

        public static void PrintPaper(string header, string content)
        {
            Console.WriteLine($"--------{header.ToUpper()}--------");
            Console.WriteLine(content);
            Console.WriteLine("-------------------------"); // TODO
        }
        
        public static string GenerateId()
        {
            return Guid.NewGuid().ToString("N");
        }
        
    }
}