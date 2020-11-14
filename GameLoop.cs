using System;

namespace TicTacToe
{
    /// <summary>
    /// Classe onde acontece o GameLoop
    /// </summary>
    class GameLoop
    {
        public bool CheckWin() {
            Table table = new Table();
            Console.WriteLine("A checkwin está a correr");
            // Horizontais
            if (table.slots[0] == "X" && table.slots[1] == "X" 
                && table.slots[2] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            } else if (table.slots[3] == "X" && table.slots[4] == "X"
               && table.slots[5] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            } else if (table.slots[6] == "X" && table.slots[7] == "X"
                 && table.slots[8] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            }
              //
              // Verticais
              else if (table.slots[0] == "X" && table.slots[3] == "X"
                  && table.slots[6] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            } else if (table.slots[1] == "X" && table.slots[4] == "X"
               && table.slots[7] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            } else if (table.slots[2] == "X" && table.slots[5] == "X"
                 && table.slots[8] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            }
            //
            // Diagonais
            else if (table.slots[0] == "X" && table.slots[4] == "X"
                && table.slots[8] == "X") {
                Console.WriteLine("Ganhou!!!");
                return true;
            } else if (table.slots[2] == "X" && table.slots[4] == "X"
               && table.slots[6] == "X") {
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
