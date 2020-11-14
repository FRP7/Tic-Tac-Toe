using System;

namespace TicTacToe
{
    /// <summary>
    /// Classe onde é desenhada o tabuleiro
    /// </summary>
    class Table
    {
        private string[] slots = new string[] {
            "1", "2", "3", "4", "5", "6", "7", "8", "9"
        };

        private void DrawTable() {
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

        public void Mark() {
            GameLoop gameloop = new GameLoop();
            string userinput;
            int input;
            while (gameloop.CheckWin() == false) {
                    Console.Clear();
                    Console.WriteLine("Escolhe uma slot para colocar X");
                    DrawTable();
                userinput = Console.ReadLine();
                input = Convert.ToInt32(userinput);
                if (userinput == input.ToString()) {
                    slots[input - 1] = "X";
                    gameloop.CheckSlot[input - 1] = "X";
                }
            }
        }
    }
}
