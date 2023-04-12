using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");
            Game newGame = new Game(FileManager.readBoard());
            PrintBoard newPrinter = new PrintBoard();
            while (true)
            {
                newGame.refreshBoard();
                newPrinter.imprimir(newGame);
            }
        }
    }
}
