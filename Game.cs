using System;

namespace TicTacToe
{
    class Game
    {
        Player player = new Player();

        public static string[] slots = new string[]
           {
                "1", "2", "3", "4", "5", "6", "7", "8", "9"
           };

        public void GameLoop() {
            Table table = new Table();
            AI ai = new AI();

            while(CheckWin() == false) {
                Console.WriteLine("Game loop");
                table.DrawTable();
                player.Play();
                CheckWin();
                ai.Play();
                CheckWin();
            }
        }

        public bool CheckWin() {
            Console.WriteLine("Check win");
            return false;
        }
    }
}
