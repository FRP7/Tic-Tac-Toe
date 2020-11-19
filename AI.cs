using System;

namespace TicTacToe
{
    /// <summary>
    /// Classe onde o computador joga.
    /// </summary>
    class AI
    {
        // Método onde a AI joga
        public void Play() {
            Console.WriteLine("Turno da AI");
            Random rnd = new Random();
            int rndPlay = rnd.Next(1, 10);
            bool isPlayed = false;

            while(isPlayed == false) {
                if(Game.slots[rndPlay -1] != "X" && Game.slots[rndPlay -1] != "O") {
                    Game.slots[rndPlay - 1] = "O";
                    isPlayed = true;
                }
                else {
                    rndPlay = rnd.Next(1, 10);
                }
            }
        }
    }
}
