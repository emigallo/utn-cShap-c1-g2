using System;


namespace TicTacToe.Models
{
    public class Player
    {
        public bool IsFirstPlayer { get; set; }
        // public string Name { get; init; }
        public char PlayerSymbol { get; init; }
        //Simbolo para jugador o 'X' o 'O'
        public string Name { get; set; }
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
