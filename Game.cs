using System;

namespace TicTacToe
{
    class Game
    {
        public static string[] slots = new string[]
           {
                "1", "2", "3", "4", "5", "6", "7", "8", "9"
           };

        public void GameLoop() {
            Player player = new Player();
            Table table = new Table();
            AI ai = new AI();

            while (CheckWin() == false) {
                Console.WriteLine("Game loop");
                table.DrawTable();
                player.Play();
                CheckWin();
                ai.Play();
                CheckWin();
            }
        }

        public bool CheckWin() {
            int count = 0;

            // Horizontais
            for (int i = 0; i < 3; i++) {
                if (slots[i] == "X") {
                    count++;
                }
                if (count == 3) {
                    Console.WriteLine("Ganhou!!!");
                    return true;
                }
            }

            count = default;
            for (int i = 3; i < 6; i++) {
                if (slots[i] == "X") {
                    count++;
                }
                if (count == 3) {
                    Console.WriteLine("Ganhou!!!");
                    return true;
                }
            }

            count = default;
            for (int i = 6; i < 9; i++) {
                if (slots[i] == "X") {
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
            for (int i = 0; i < 7; i += 3) {
                if (slots[i] == "X") {
                    count++;
                }
                if (count == 3) {
                    Console.WriteLine("Ganhou!!!");
                    return true;
                }
            }

            count = default;
            for (int i = 1; i < 8; i += 3) {
                if (slots[i] == "X") {
                    count++;
                }
                if (count == 3) {
                    Console.WriteLine("Ganhou!!!");
                    return true;
                }
            }

            count = default;
            for (int i = 2; i < 9; i += 3) {
                if (slots[i] == "X") {
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
                if (slots[i] == "X") {
                    count++;
                }
                if (count == 3) {
                    Console.WriteLine("Ganhou!!!");
                    return true;
                }
            }

            count = default;
            for (int i = 2; i < 7; i += 2) {
                if (slots[i] == "X") {
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
}
