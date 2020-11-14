﻿using System;

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
            int count = 0;

            // Horizontais
            for(int i = 0; i < 3; i++) {
                if(CheckSlot[i] == "X") {
                    count++;
                }
                if(count == 3) {
                    Console.WriteLine("Ganhou!!!");
                    return true;
                }
            }

            count = default;
            for(int i = 3; i < 6; i++) {
                if (CheckSlot[i] == "X") {
                    count++;
                }
                if (count == 3) {
                    Console.WriteLine("Ganhou!!!");
                    return true;
                }
            }

            count = default;
            for (int i = 6; i < 9; i++) {
                if (CheckSlot[i] == "X") {
                    count++;
                }
                if (count == 3) {
                    Console.WriteLine("Ganhou!!!");
                    return true;
                }
            }
            //
            // Verticais
            count = default;
            for (int i = 0; i < 7; i+= 3) {
                if (CheckSlot[i] == "X") {
                    count++;
                }
                if (count == 3) {
                    Console.WriteLine("Ganhou!!!");
                    return true;
                }
            }

            count = default;
            for (int i = 1; i < 8; i += 3) {
                if (CheckSlot[i] == "X") {
                    count++;
                }
                if (count == 3) {
                    Console.WriteLine("Ganhou!!!");
                    return true;
                }
            }

            count = default;
            for (int i = 2; i < 9; i += 3) {
                if (CheckSlot[i] == "X") {
                    count++;
                }
                if (count == 3) {
                    Console.WriteLine("Ganhou!!!");
                    return true;
                }
            }

            //
            // Diagonais
            count = default;
            for (int i = 0; i < 9; i += 4) {
                if (CheckSlot[i] == "X") {
                    count++;
                }
                if (count == 3) {
                    Console.WriteLine("Ganhou!!!");
                    return true;
                }
            }

            count = default;
            for (int i = 2; i < 7; i += 2) {
                if (CheckSlot[i] == "X") {
                    count++;
                }
                if (count == 3) {
                    Console.WriteLine("Ganhou!!!");
                    return true;
                }
            }
            //
            // Se não há linha em nenhum desses lados, retorna falso.
            return false;
            //
        }
    }
    //
}
