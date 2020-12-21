using System;

namespace Prueba
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int numero = 1;
            string mes = "Febrero";
            bool estaLloviendo = false;
            float dinero = 14.2f;
            int x = 10;
            int y = 10;
            int index = 0;

            ConsoleColor[] colores = {ConsoleColor.Blue,ConsoleColor.Yellow,ConsoleColor.Green,ConsoleColor.White,ConsoleColor.Cyan,ConsoleColor.Magenta,ConsoleColor.Green,ConsoleColor.DarkBlue,ConsoleColor.DarkGreen,ConsoleColor.White};
            
            while (true)
            {
                for(int j = 0; j < 10 ; j++)
                    {
                System.Threading.Thread.Sleep(800);

                y = 10;

                Console.SetCursorPosition(x,y);
                Console.BackgroundColor = colores[index];
                for(int i = 0; i < 10; i++)
                        {
                        Console.SetCursorPosition(x,y);
                        Console.WriteLine("                    ");   
                            y++;
                        }    
               
                
                index = j;
                }

            }


            Console.ReadKey();

        }

            
    }
    
}
