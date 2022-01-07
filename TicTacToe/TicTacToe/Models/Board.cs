using System;

namespace TicTacToe.Models
{
    public class Board
    {
        private Dictionary<int, char> _map;
        /*Map[20]=Simbolo*/


        public int Turns { get; private set; }

        private Dictionary<int, char> _winnerLine;

        public Board()
        {
            _map = new Dictionary<int, char>();
            for (int i = 1; i < 10; i++)
            {
                _map.Add(i, ' ');
            }
            Turns = 0;
            _winnerLine = new Dictionary<int, char>();
            for(int i = 0; i < 10; i++)
            {
                _winnerLine.Add(i, ' ');
            }
           
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
        public string WhoIsTheWinner()
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
        private char GetPlayerSymbol(int Position)
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
                if (IsOccupied(j) && ComparePositions(j,j+3,j+6))
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
            if (IsOccupied(1) && ComparePositions(1,5,9))
            {
                return "" + GetPlayerSymbol(1);
            }
            if (IsOccupied(3) && ComparePositions(3,5,7))
            {
                return "" + GetPlayerSymbol(3);
            }
            return null;
        }


        //Verifica todas las Filas y se fija si encuentra un 3 en linea
        private string VerifyRows()
        {
            int Sumatory = 0;
            for (int j = 0; j < 3; j++)
            {

                if (IsOccupied(1 + Sumatory) && ComparePositions(1+Sumatory,2+Sumatory,3+Sumatory))
                {
                    return "" + _map[1 + Sumatory];
                }
                Sumatory += 3;
            }
            return null;
        }

        private bool ComparePositions(int a, int b, int c)
        {
            if(GetPlayerSymbol(a) == GetPlayerSymbol(b) && GetPlayerSymbol(c) == GetPlayerSymbol(a))
            {
                SetWinnerLine(a, b, c, GetPlayerSymbol(a));
                return true;
            }
            return false;
        }

        private void SetWinnerLine(int a, int b, int c, char symbol)
        {
            _winnerLine[a] = symbol;
            _winnerLine[b] = symbol;
            _winnerLine[c] = symbol;
        }
    }
}