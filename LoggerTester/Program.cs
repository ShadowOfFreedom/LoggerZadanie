using System;

namespace LoggerTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Logger logger = new Logger.Logger();

            Console.Write("Podaj nazwę pliku:");
            var fileName = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Podaj tekst wiadomości:");
                var text = Console.ReadLine();
                try
                {
                    logger.Log(text);
                }
                catch (Exception e)
                {
                    Console.Write($"Wystąpił błąd {e.Message}, w jakim plku chcesz go zapisać:");
                    var errorFileName = Console.ReadLine();

                    logger.Log(e.Message, errorFileName);
                }

            }

        }
    }
}
