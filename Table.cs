using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    /// <summary>
    /// Classe onde é desenhada o tabuleiro
    /// </summary>
    class Table
    {
        public string[] slots = new string[] {
            "1", "2", "3", "4", "5", "6", "7", "8", "9"
        };

        private void DrawTable() {
            Console.WriteLine($"    |     |   ");
            Console.WriteLine($" {slots[0]}  |  {slots[1]}  | {slots[2]}   "); 
            Console.WriteLine($"____|_____|____"); 
            Console.WriteLine($"    |     |   ");
            Console.WriteLine($"  {slots[3]} |  {slots[4]}  | {slots[5]}   ");
            Console.WriteLine($"____|_____|____"); 
            Console.WriteLine($"    |     |   "); 
            Console.WriteLine($" {slots[6]}  |  {slots[7]}  |  {slots[8]}  ");
            Console.WriteLine($"    |     |   ");
        }

        public void Mark() {
            GameLoop gameloop = new GameLoop();
            string userinput;
            while (gameloop.CheckWin() == false) {
                    Console.Clear();
                    Console.WriteLine("Escolhe uma slot para colocar X");
                    DrawTable();
                    userinput = Console.ReadLine();
                    if (userinput == slots[0]) {
                        slots[0] = "X";
                    gameloop.CheckSlot[0] = "X";
                    }
                    if (userinput == slots[1]) {
                        slots[1] = "X";
                    gameloop.CheckSlot[1] = "X";
                }
                    if (userinput == slots[2]) {
                        slots[2] = "X";
                    gameloop.CheckSlot[2] = "X";
                }
                    if (userinput == slots[3]) {
                        slots[3] = "X";
                    gameloop.CheckSlot[3] = "X";
                }
                    if (userinput == slots[4]) {
                        slots[4] = "X";
                    gameloop.CheckSlot[4] = "X";
                }
                    if (userinput == slots[5]) {
                        slots[5] = "X";
                    gameloop.CheckSlot[5] = "X";
                }
                    if (userinput == slots[6]) {
                        slots[6] = "X";
                    gameloop.CheckSlot[6] = "X";
                }
                    if (userinput == slots[7]) {
                        slots[7] = "X";
                    gameloop.CheckSlot[7] = "X";
                }
                    if (userinput == slots[8]) {
                        slots[8] = "X";
                    gameloop.CheckSlot[8] = "X";
                }
                    gameloop.CheckWin();
                }
            }
        }
    }
