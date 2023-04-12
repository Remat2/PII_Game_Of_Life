using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class PrintBoard
    {
        bool[,] b;//variable que representa el tablero
        int width; //variabe que representa el ancho del tablero
        int height; //variabe que representa altura del tablero
        public void imprimir(Game Gamestate){
            this.b = Gamestate.gameBoard;
            this.width = b.GetLength(0);
            this.height = b.GetLength(1);
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(b[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            //=================================================
            //Invocar método para calcular siguiente generación
            //=================================================
            Thread.Sleep(300);
            
        }
    }
}