using System;


namespace TicTacToe.Models
{
    internal class Player
    {
        public bool IsFirstPlayer { get; set; }
        // public string Name { get; init; }
        private char PlayerSymbol { get; init; }
        //Simbolo para jugador o 'X' o 'O'
        public Player(char Symbol)
        {
            this.PlayerSymbol = Symbol;
            this.IsFirstPlayer = false;
        }

        //Marca un casillero del tateti
        public void Mark(int Position,Board Boards) 
        {
            //if(Occupied(Position,Boards))
            /**/
            //Primero tengo que preguntar si la celda esta ocupada
            Boards.Map[Position] = this.PlayerSymbol;


        }
    }
}
