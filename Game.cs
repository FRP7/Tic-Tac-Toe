using System;

namespace TicTacToe
{
    class Game
    {
        public string[] checkSlot = new string[9];

        public void GameLoop() {
            Table table = new Table();
            Player player = new Player();
            AI ai = new AI();

            /*while(CheckWin() == false) {
                Console.WriteLine("Game loop");
                table.DrawTable();
                player.Play();
                CheckWin();
                ai.Play();
                CheckWin();
            }*/
            table.DrawTable();
            player.Play();
            CheckWin();
            table.DrawTable();
        }

        public bool CheckWin() {
            Console.WriteLine("Check win");

            return false;
        }
    }
}
