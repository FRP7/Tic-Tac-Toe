using System;
using System.Collections.Generic;

namespace TicTacToe
{
    /// <summary>
    /// Classe onde o computador joga.
    /// </summary>
    class AI {
        // Avaliação estática.
        private static int heuristic;
        private int maxEval;
        private int minEval;
        private string eval;

        /*// Lista de possíveis vitórias
        private static List<string[]> winConditions = new List<string[]>() {
            new string[] {"1", "2", "3"},
             new string[] {"4", "5", "6"},
              new string[] {"7", "8", "9"},
               new string[] {"1", "4", "7"},
                new string[] {"2", "5", "8"},
                 new string[] {"3", "6", "9"},
                  new string[] {"1", "5", "9"},
                   new string[] {"3", "5", "7"}
        };*/

        // Dicionário de possíveis vitórias
        private static Dictionary<string[], int> winCondition = new Dictionary<string[], int>() {
            {new string[] {"1", "2", "3"}, 0 },
            {new string[] {"4", "5", "6"}, 0 },
            {new string[] {"7", "8", "9"}, 0 },
            {new string[] {"1", "4", "7"}, 0 },
            {new string[] {"2", "5", "8"}, 0 },
            {new string[] {"3", "6", "9"}, 0 },
            {new string[] {"1", "5", "9"}, 0 },
            {new string[] {"3", "5", "7"}, 0 }
        };

        // Método onde a AI joga
        public void Play() {
            Console.WriteLine("Turno da AI");
            //Minimax();
            /*Console.WriteLine("Turno da AI");
            Random rnd = new Random();
            int rndPlay = rnd.Next(1, 10);
            bool isPlayed = false;

            while(isPlayed == false) {
                if(Game.slots[rndPlay -1] != "X" && Game.slots[rndPlay -1] != "O") {
                    Game.slots[rndPlay - 1] = "O";
                    isPlayed = true;
                }
                else {
                    rndPlay = rnd.Next(1, 10);
                }
            }*/
        }

        private void Minimax(string position, int depth, bool maximizingPlayer) {
            /*if(depth == 0 ou que o jogo está perdido na posição Y) { 
                // retomar avaliação de position
            }*/

            if (maximizingPlayer == true) {
                maxEval = -10000;
                // foreach de lista de posições possívels
                /*foreach(var item in lista)
                 * {
                 * eval = minimax(item, depth -1, false);
                 * maxEval = max(maxEval, eval) buscar o valor mais alto
                 * }
                 * retomar maxEval
                 */
            } else {
                minEval = 10000;
                /*
                 * foreach de lista de posições possíveis
                 * foreach(var item in lista)
                 * {
                 * eval = minimax(item, depth -1, true);
                 * minEval = min(minEval, eval)
                 * }
                 * retomar minEval
                 */
            }
        }
    }
}
