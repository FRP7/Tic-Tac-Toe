﻿using System;

namespace TicTacToe
{
    class Table
    {
        public void DrawTable() {
            Console.WriteLine($"     |     |   ");
            Console.WriteLine($"  {Game.slots[0]}  |  {Game.slots[1]}  |  {Game.slots[2]}   ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"     |     |   ");
            Console.WriteLine($"  {Game.slots[3]}  |  {Game.slots[4]}  |  {Game.slots[5]}   ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"     |     |   ");
            Console.WriteLine($"  {Game.slots[6]}  |  {Game.slots[7]}  |  {Game.slots[8]}  ");
            Console.WriteLine($"     |     |   ");
        }
    }
}
