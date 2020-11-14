using System;

namespace TicTacToe
{
    /// <summary>
    /// Classe onde começa o programa.
    /// Não faz mais nada sem ser chamar a classe Game.
    /// </summary>
    class Program
    {
        static void Main(string[] args) {
            Game game = new Game();
            game.Teste();
        }
    }
    //
}
