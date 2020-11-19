using System;

namespace TicTacToe
{
    /// <summary>
    /// Classe onde o jogador joga.
    /// </summary>
    class Player
    {
        // Método onde o jogador joga
        public void Play() {
            Console.WriteLine("Turno do jogador:");
            Game game = new Game();
            string userInput;
            int input;
            bool isInput = false;

            while (isInput == false) {
                userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out input) &&
                    input <= Game.slots.Length && Game.slots[input - 1] != "X") {
                    Game.slots[input - 1] = "X";
                    isInput = true;
                } else {
                    Console.WriteLine("Valor inválido, tente de novo");
                }
            }
        }
    }
}
