using System;
using System.Collections.Generic;

namespace TicTacToe
{
    /// <summary>
    /// Classe onde o computador joga.
    /// </summary>
    class AI {

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
            Minimax(2000, 0);
            Game.slots[HighestScore()] = "O";
        }

        private void Evaluate() {
            if(Game.slots[0] == "X") {
                possiblePlays[1] += 1;
            }
            if (Game.slots[1] == "X") {
                possiblePlays[4] += 1;
            }
            if (Game.slots[2] == "X") {
                possiblePlays[1] += 1;
            }
            if (Game.slots[3] == "X") {
                possiblePlays[4] += 1;
            }
            if (Game.slots[4] == "X") {
                possiblePlays[1] += 1;
            }
            if (Game.slots[5] == "X") {
                possiblePlays[4] += 1;
            }
            if (Game.slots[6] == "X") {
                possiblePlays[7] += 1;
            }
            if (Game.slots[7] == "X") {
                possiblePlays[4] += 1;
            }
            if (Game.slots[8] == "X") {
                possiblePlays[7] += 1;
            }
        }

        private void Minimax(int maxDepth, int currentDepth) {
            if(currentDepth < maxDepth) {
                /* Para cada jogada possível, chamar Minimax(currentDepth +1)
                 * Devolver melhor jogada*/
                foreach(KeyValuePair<int, int> play in possiblePlays) {
                    Minimax(maxDepth, currentDepth + 1);
                    Evaluate();
                }
            }
        }

        private int HighestScore() {
            // Jogada escolhida
            int chosenPlay;
            // Valor máximo da jogada
            int maxValue;
            // Converter os valores do dicionário para array
            int[] highest = new int[possiblePlays.Count];
            possiblePlays.Values.CopyTo(highest, 0);
            // Ordenar a array por ordem crescente
            Array.Sort(highest);
            // Buscar o valor que está no topo (que é o mais alto)
            maxValue = highest[highest.Length - 1];
            // Procurar chave do valor máximo no dicionário
            chosenPlay = possiblePlays[maxValue];
            // Devolver a jogada escolhida
            return chosenPlay;
        }
    }
}
