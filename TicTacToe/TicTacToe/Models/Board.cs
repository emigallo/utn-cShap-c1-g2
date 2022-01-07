using System;

namespace TicTacToe.Models
{
    public class Board
    {
        private Dictionary<int, char> _map;
        /*Map[20]=Simbolo*/


        public int Turns { get; private set; }

        public Board()
        {
            _map = new Dictionary<int, char>();
            for (int i = 1; i < 10; i++)
            {
                _map.Add(i, ' ');
            }
            Turns = 0;
        }

        public void Draw()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.Write(_map[i]);
                Console.Write('|');
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }
            }

        }

        //Marca el tablero
        public void Mark(int position, char Symbol)
        {
            if (IsValidCell(position))
            {
                _map[position] = Symbol;
                this.Turns++;

            }
            else
            {
                Console.WriteLine("Debe seleccionar una posicion valida");
            }
            
        }

        //Revisa todo el map y verifica quien gana
        /*
         *  si gano unjugador retorna susimbolo
         *  si no retorna null
         */
        public string IsThereAWinner()
        {
            //Verify(jugador1.Symbol)
            //Validaciones(jugador1.Symbol)
            //Validaciones(jugador2.Symbol)
            //Tiene que usar FullBoard para saber si es empate o si sigue el juego en curso
            string winner = "Empate";

            if (VerifyRows() != null)
            {
                winner = VerifyRows();
                return winner;
            }
            if (VerifyDiagonals() != null)
            {
                winner = VerifyDiagonals();
                return winner;
            }
            if (VerifyColumns() != null)
            {
                winner = VerifyColumns();
                return winner;
            }

            if (FullBoard())
            {
                return "Empate";
            }
            return " ";
        }

        //Si el tablero esta lleno retorna true
        private bool FullBoard()
        {
            int Counter = 0;
            for (int i = 1; i < 10; i++)
            {
                if (IsOccupied(i))
                {
                    Counter++;
                }
            }
            if (Counter == 9)
            {
                return true;
            }
            return false;
        }

        //Elije al primer Jugador : 'X' o 'O'
        public bool ChooseFirstPlayer()
        {

            int num = new Random().Next(0, 1);
            if (num == 1)
            {
                return true;
            }
            return false;
        }

        //Funcion para limpiar el tablero y volver a jugar.
        public void ClearBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                _map[i] = ' ';
            }
            this.Turns = 0;
        }

        //Verificaciones

        //Devuelve true si la celda esta ocupada
        private bool IsOccupied(int Position)
        {
            return (_map[Position] == 'X' || _map[Position] == 'O');
        }

        //Devuelve el char de una celda ocupada
        private char charOccupied(int Position)
        {
            //Cambiar el if para que solo devuelva el simbolo si esta ocupada
            if (IsOccupied(Position) && Position >= 1 && Position <= 9)
            {
                return _map[Position];
            }
            return ' ';
        }

        private bool IsValidCell(int Position)
        {
            return Position >= 1 && Position <= 9 && !IsOccupied(Position);
        }

        //Verifca todas las columnas y devuelve si se cumple un 3 en linea
        //Devuelve el caracter de las columnas
        private string VerifyColumns()
        {
            for (int j = 1; j < 4; j++)
            {
                if (IsOccupied(j) && charOccupied(j) == charOccupied(j + 3) && charOccupied(j) == charOccupied(j + 6))
                {
                    return "" + _map[j];
                }
            }

            return null;
        }

        //Verifica las diagonales
        private string VerifyDiagonals()
        {
            //Agrege IsOccupied por que devolvia siempre null
            if (IsOccupied(1) && charOccupied(1) == charOccupied(5) && charOccupied(1) == charOccupied(9))
            {
                return "" + charOccupied(1);
            }
            if (charOccupied(3) == charOccupied(5) && charOccupied(3) == charOccupied(7) && IsOccupied(3))
            {
                return "" + charOccupied(3);
            }
            return null;
        }


        //Verifica todas las Filas y se fija si encuentra un 3 en linea
        private string VerifyRows()
        {
            int Sumatory = 0;
            for (int j = 0; j < 3; j++)
            {

                if (IsOccupied(1 + Sumatory) && charOccupied(1 + Sumatory) == charOccupied(2 + Sumatory) && charOccupied(1 + Sumatory) == charOccupied(3 + Sumatory))
                {
                    return "" + _map[1 + Sumatory];
                }
                Sumatory += 3;
            }
            return null;
        }
    }
}