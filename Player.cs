using System;

namespace TicTacToe
{
    class Player
    {
        public void Play() {
            Console.WriteLine("Turno do jogador:");
            Game game = new Game();
            string userinput;
            int input;
            bool isInput = false;

            while (isInput == false) {
                userinput = Console.ReadLine();
                if (Int32.TryParse(userinput, out input)) {
                    Console.WriteLine("Escolha uma casa");
                    Game.slots[input - 1] = "X";
                    isInput = true;
                } else {
                    Console.WriteLine("Valor inválido, tente de novo");
                }
            }
        }
    }
}
