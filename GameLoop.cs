using System;

namespace TicTacToe
{
    /// <summary>
    /// Classe onde acontece o GameLoop
    /// </summary>
    class GameLoop
    {
        public string[] CheckSlot = new string[9];
        public bool CheckWin() {
            Table table = new Table();
            Console.WriteLine("A checkwin está a correr");
            // Horizontais
            if (CheckSlot[0] == "X" && CheckSlot[1] == "X" 
                && CheckSlot[2] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            } else if (CheckSlot[3] == "X" && CheckSlot[4] == "X"
               && CheckSlot[5] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            } else if (CheckSlot[6] == "X" && CheckSlot[7] == "X"
                 && CheckSlot[8] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            }
              //
              // Verticais
              else if (CheckSlot[0] == "X" && CheckSlot[3] == "X"
                  && CheckSlot[6] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            } else if (CheckSlot[1] == "X" && CheckSlot[4] == "X"
               && CheckSlot[7] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            } else if (CheckSlot[2] == "X" && CheckSlot[5] == "X"
                 && CheckSlot[8] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            }
            //
            // Diagonais
            else if (CheckSlot[0] == "X" && CheckSlot[4] == "X"
                && CheckSlot[8] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            } else if (CheckSlot[2] == "X" && CheckSlot[4] == "X"
               && CheckSlot[6] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            }
            //
            // Se não há linha em nenhum desses lados, retorna falso.
            else {
                return false;
            }
        }
    }
    //
}
