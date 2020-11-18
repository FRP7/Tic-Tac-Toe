using System;

namespace TicTacToe
{
    class Table
    {
        public void DrawTable() {
            Game game = new Game();
            Console.WriteLine($"     |     |   ");
            Console.WriteLine($"  {game.slots[0]}  |  {game.slots[1]}  |  {game.slots[2]}   ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"     |     |   ");
            Console.WriteLine($"  {game.slots[3]}  |  {game.slots[4]}  |  {game.slots[5]}   ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"     |     |   ");
            Console.WriteLine($"  {game.slots[6]}  |  {game.slots[7]}  |  {game.slots[8]}  ");
            Console.WriteLine($"     |     |   ");

            foreach(var teste in game.slots) {
                Console.WriteLine("Slots: " + teste);
            }
        }
    }
}
