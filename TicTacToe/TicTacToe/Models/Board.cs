using System;

namespace TicTacToe.Models
{
    public class Board
    {
        public Dictionary<int, char> Map;
        /*Map[Valor]=Simbolo*/
        
        
        public Board()
        {
            Map = new Dictionary<int, char>();
            for(int i = 1; i < 10; i++){
                Map.Add(i, ' ');
            }
        }

        //Revisa todo el map y verifica quien gana
        public bool IsThereAWinner()
        {
            //Verify(jugador1.Symbol)
            //Validaciones(jugador1.Symbol)
            //Validaciones(jugador2.Symbol)
            //Tiene que usar FullBoard para saber si es empate o si sigue el juego en curso
            return true;
        }

        //Si el tablero esta lleno retorna true
        //Se va a cambiar a Validations
        public bool FullBoard()
        {
            return true;
        }

        //Pregunta si esta ocupada a casilla
        //Se cambia a Validations
        public bool Occupied(int Position, char Value)
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




    }
}