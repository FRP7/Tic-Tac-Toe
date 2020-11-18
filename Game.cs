using System;

namespace TicTacToe
{
    class Game
    {
        public void GameLoop() {
            Table table = new Table();
            Player player = new Player();
            AI ai = new AI();
            /*Console.WriteLine("Game loop");
            table.DrawTable();
            player.Play();
            CheckWin();
            ai.Play();
            CheckWin();*/

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
