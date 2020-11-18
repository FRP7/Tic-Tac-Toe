using System;

namespace TicTacToe
{
    /// <summary>
    /// Classe onde começa o jogo.
    /// </summary>
    class Program
    {
        static void Main(string[] args) {
            // Iniciar o jogo.
            Game game = new Game();
            game.GameLoop();
            //
        }
    }
}
