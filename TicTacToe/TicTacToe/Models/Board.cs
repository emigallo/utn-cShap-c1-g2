using System;

namespace TicTacToe.Models
{
    public class Board
    {
        private Dictionary<int, char> Map;
        /*Map[20]=Simbolo*/
        private int Turns { get; set; }
        
        
        public Board()
        {
            Map = new Dictionary<int, char>();
            for(int i = 1; i < 10; i++){
                Map.Add(i, ' ');
            }
            Turns = 0;
        }

        //Marca el tablero
        public void Mark(int position, char Symbol)
        {
            if (IsValidCell(position))
            {
                //Marcar el map con el simbolo del jugador que lo llama
                //Player player = new Player();
                Map.Add(position, Symbol);

            }
            else
            {
                Console.WriteLine("Debe seleccionar una posicion valida");
            }
            Turns++;
        }

        //Revisa todo el map y verifica quien gana
        /*
         *  si gano unjugador retorna susimbolo
         *  si no retorna null
         */
        public string IsThereAWinner()
        {
            string winner = null;
            if(!FullBoard())
            {
                if(VerifyRows() != null)
                {
                    winner = VerifyRows();
                }
                if(VerifyDiagonals() != null)
                {
                    winner = VerifyDiagonals();
                }
                if(VerifyColumns() != null)
                {
                    winner = VerifyColumns();
                }
            }
            return winner;
            //Verify(jugador1.Symbol)
            //Validaciones(jugador1.Symbol)
            //Validaciones(jugador2.Symbol)
            //Tiene que usar FullBoard para saber si es empate o si sigue el juego en curso
        }

        //Si el tablero esta lleno retorna true
        private bool FullBoard()
        {

            return true;
        }

        //Elije al primer Jugador : 'X' o 'O'
        public bool ChooseFirstPlayer()
        {

            int num = new Random().Next(0,1);
            if(num == 1) { 
                return true;
            }
            return false;
        }

        //Funcion para limpiar el tablero y volver a jugar.
        public void ClearBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                Map[i] = ' ';
            }
        }

        //Verificaciones

        //Devuelve true si la celda esta ocupada
        private bool IsOccupied(int Position)
        {
            return (Map[Position] == 'X' || Map[Position] == 'O');
        }

        //Devuelve el char de una celda ocupada
        private char charOccupied(int Position)
        {
            //Cambiar el if para que solo devuelva el simbolo si esta ocupada
            if (IsOccupied(Position) && Position >= 1 && Position <= 9)
            {
                return Map[Position];
            }
            return ' ';
        }

        private bool IsValidCell(int Position)
        {
            return (!IsOccupied(Position) && Position >= 1 && Position <= 9);
        }

        //Verifca todas las columnas y devuelve si se cumple un 3 en linea
        //Devuelve el caracter de las columnas
        private string VerifyColumns()
        {
            /*1|2|3
              4|5|6
              7|8|9
            */
            //1|2|3|4|5|6|7|8|9
            int Sumatory = 0, counter = 1 ;
            for(int j=0; j < 3; j++) {
                Sumatory = 0;
                counter = 1;
                /*
                 Este for verifica solo 1 Columna , Ejemplo:
                 Primera iteracion:
                    1|
                    4|
                    7|

                 */
                for (int i = 0; i < 3; i++) { 
                    if(charOccupied(1+Sumatory)==Map[1+j])
                    {
                        counter++;
                        Sumatory += 3;
                    }
                }
                if (counter == 3)
                {
                    return ""+ Map[1+j];
                }
            }
            
            return null;
        }

        //Verifica las diagonales
        private string VerifyDiagonals()
        {
            /*1|2|3
              4|5|6
              7|8|9
            */
            if (charOccupied(1) == charOccupied(5) && charOccupied(1) == charOccupied(9))
            {
                return ""+charOccupied(1);
            }
            if(charOccupied(3) == charOccupied(5) && charOccupied(3) == charOccupied(7))
            {
                return "" + charOccupied(3);
            }
            return null;
        }


        //Verifica todas las Filas y se fija si encuentra un 3 en linea
        public string VerifyRows()
        {
            /*1|2|3
              4|5|6
              7|8|9
            */
            //1|2|3|4|5|6|7|8|9
            int counter = 1,Sumatory=0;
            for (int j = 0; j < 3; j++)
            {
                counter = 1;
                for (int i = 0; i < 3; i++)
                {
                    if (charOccupied(1 + Sumatory) == Map[1+i])
                    {
                        counter++;
                    }
                    if (counter == 3)
                    {
                        return "" + Map[1 + i];
                    }
                }
                
                Sumatory += 3;
            }
            return null;
        }
    }
}