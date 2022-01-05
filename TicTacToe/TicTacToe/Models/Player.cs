using System;


namespace TicTacToe.Models
{
    internal class Player
    {
        public bool IsFirstPlayer { get; set; }
        // public string Name { get; init; }
        private char PlayerSymbol { get; init; }
        //Simbolo para jugador o 'X' o 'O'
        private string Name { get; set; }
        public Player(char Symbol, string Names)
        {
            this.PlayerSymbol = Symbol;
            this.IsFirstPlayer = false;
            this.Name = Names;
        }

        //test numero 2 buenosdias
        public void Mark(int Position,Board TicTacToe)
        {
            TicTacToe.Mark(Position, this.PlayerSymbol);
        }

    }
}
