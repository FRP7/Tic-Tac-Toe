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

        // Dicionário de jogadas possíveis com o score a 0 por default
        private static Dictionary<int, int> possiblePlays = new Dictionary<int, int>() {
            {0, 0}, // escolher casa 1
            {1, 0}, // escolher casa 2
            {2, 0}, // escolher casa 3
            {3, 0}, // escolher casa 4
            {4, 0}, // escolher casa 5
            {5, 0}, // escolher casa 6
            {6, 0}, // escolher casa 7
            {7, 0}, // escolher casa 8
            {8, 0}  // escolher casa 9
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

        private void Evaluate() {
            if(Game.slots[0] == "X") {
                
            }
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
