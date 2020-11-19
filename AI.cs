using System;

namespace TicTacToe
{
    /// <summary>
    /// Classe onde o computador joga.
    /// </summary>
    class AI
    {
        // Avaliação estática.
        private static int heuristic;
        private int maxEval;
        private int minEval;
        private string eval;

        // Método onde a AI joga
        public void Play() {
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

            if(maximizingPlayer == true) {
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
