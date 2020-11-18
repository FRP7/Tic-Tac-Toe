using System;

namespace TicTacToe
{
    class Table
    {
        private string[] slots = new string[] {
            "1", "2", "3", "4", "5", "6", "7", "8", "9"
        };

        public void DrawTable() {
            DrawMark();
            Console.WriteLine($"     |     |   ");
            Console.WriteLine($"  {slots[0]}  |  {slots[1]}  |  {slots[2]}   ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"     |     |   ");
            Console.WriteLine($"  {slots[3]}  |  {slots[4]}  |  {slots[5]}   ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"     |     |   ");
            Console.WriteLine($"  {slots[6]}  |  {slots[7]}  |  {slots[8]}  ");
            Console.WriteLine($"     |     |   ");
        }

        private void DrawMark() {
            Game game = new Game();
        }
    }
}
