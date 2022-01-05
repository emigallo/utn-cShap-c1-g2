using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Validations
{
    internal class Occupied
    {
        //Devuelve true si la celda esta ocupada.
        public bool IsOccupied(int Position,Board Boards)
        {
            return (Boards.Map[Position] == 'X' || Boards.Map[Position] == 'O');
        }

        //Si la celda esta ocupada devuelve su simbolo, de lo contrario devuelve ' '
        public char IsOccupied(int Position,Board Boards,char Symbol)
        {
            //Cambiar el if para que solo devuelva el simbolo si esta ocupada
            if(IsOccupied(Position, Boards) && Boards.Map[Position] == Symbol)
            {
                return Symbol;
            }
            return ' ';
            
        }
    }
}
