using System;

namespace TicTacToe
{
    class Player
    {
        public void Play() {
            Console.WriteLine("Player plays");
            Game game = new Game();
            string userinput;
            int input;

            userinput = Console.ReadLine();

              if(Int32.TryParse(userinput, out input)) { 
                Console.WriteLine("jogar");
                game.checkSlot[input - 1] = "X";
            }
              else {
                Console.WriteLine("Valor inválido, tente de novo");
            }
        }
    }
}
