using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace UI.ViewModel
{
    class TicTacToeViewModel
    {
        /*Metodos a implementar:
         WhoPlays(Player id,Player id2) Retorna que jugador juega en ese turno
         SetName(Player id) Cambia el nombre del jugador (Opcional)
         Mark(Posicion) Marca la posicion en el tablero con el simbolo del jugador que juega en ese turno
        */
        private Board _board { get; init; }
        private Player _player1  { get; set; }
        private Player _player2 { get; set; }
        public TicTacToeViewModel()
        {
            this._board = new Board();
            this._player1 = new Player('X', "Player One");
            this._player2 = new Player('O', "Player Two");
        }

        public int TransformCoordinates(int RowCoordinates,int ColumnCoordinates)
        {
            return (((RowCoordinates+1) * 3) + ColumnCoordinates+1);
        }

        public void Mark(int Position,char PlayerSymbol)
        {
            //No puedo traer el playerSymbol desde Views
            //hacer un if o metodo para saber que jugador empezo o que jugador me esta dando que simbolo

            //Posibles consideraciones:

            /*Este metodo va a ser el mas extenso de todos ya que practicamente es la magia del tateti
             * Tenemos que verificar muchas cosas y aplicar toda la logica en esta clase antes que en Views
             * Realizar metodos que me digan que player juega ahora y hacer uso del Turns del _board
             */
            _board.Mark(Position,PlayerSymbol); 
            //O le decimos a board que marque o le decimos a player, Preferiblemente player asi ya tiene su 
            /*Usamos la funcion WhoPlays(player 1,player 2).Mark(Position) como posible camino*/
        }
    }
}
