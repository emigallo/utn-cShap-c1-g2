using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;
using System.Windows.Controls;

namespace UI.ViewModel
{
    public class TicTacToeViewModel
    {
        /*Metodos a implementar:
         
         SetName(Player id) Cambia el nombre del jugador (Opcional) hacer en TicTacToe
         Dar la opcion de cambiar el nombre a los jugadores
         Cuando hay un ganador , desactivar el resto de los botones y marcar la linea ganadora
         Cuando el juego termina , habilitar el boton de Empezar de nuevo(opcional)
         Antes que el juego empieze tener la opcion de "Tirar moneda" para elegir primer jugador(opcional)
         Mostrar la linea ganadora del jugador que la realizo (Ultimo)
         
        */
        private Board _board { get; set; }
        private Player _player1  { get; set; }
        private Player _player2 { get; set; }
        public TicTacToeViewModel()
        {
            this._board = new Board();
            this._player1 = new Player('X', "Player One");
            this._player2 = new Player('O', "Player Two");
        }

        private int TransformCoordinates(int RowCoordinates,int ColumnCoordinates)
        {
            //1|2|3
            //4|5|6
            //7|8|9
            return (((RowCoordinates) * 3) + ColumnCoordinates+1);
        }

        public char Mark(int Row,int Column)
        {
            Player nextPlayer = GetNextPlayer(_player1, _player2);
            int MarkPosition = TransformCoordinates(Row, Column);
            //Marked = MarkPlayer.PlayerSymbol;
            nextPlayer.Mark(MarkPosition,this._board);
            return nextPlayer.PlayerSymbol;
            //MarkPlayer = null; <- Hago esto para no tener memory leaks?
        }

        private Player GetNextPlayer(Player PlayerOne,Player PlayerTwo)
        {
            if (_board.Turns % 2 == 0)
            {
                return PlayerOne;
            }
            return PlayerTwo;
        }

    }
}
