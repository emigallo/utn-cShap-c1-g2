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
    public class TicTacToeViewModel : INotifyPropertyChanged
    {
        /*Metodos a implementar:
         
         SetName(Player id) Cambia el nombre del jugador (Opcional) hacer en TicTacToe (Completado)
         Dar la opcion de cambiar el nombre a los jugadores (Completado)
         Cuando hay un ganador , desactivar el resto de los botones (Completado)
         Cuando el juego termina , habilitar el boton de Empezar de nuevo(opcional) (En curso)
         Antes que el juego empieze tener la opcion de "Tirar moneda" para elegir primer jugador(opcional)
         Mostrar la linea ganadora del jugador que la realizo (Ultimo)
         
        */
        private Board _board { get; set; }
        private Player _player1  { get; set; }
        private Player _player2 { get; set; }

        private string _buttonContent = " ";
        public string ButtonContent {
            get
            {
                return this._buttonContent;
            }
            set
            {
                this._buttonContent = value;
                OnPropertyNameChanged(nameof(ButtonContent));
            }
        }

        private bool _buttonsPlaying = true;

        public bool ButtonsPlaying {
            get
            {
                return this._buttonsPlaying;
            }
            set
            {
                this._buttonsPlaying = value;
                OnPropertyNameChanged(nameof(ButtonsPlaying));
            }
        }

        private bool _playing = true;

        public bool IsPlaying {
            get
            {
                return _playing;
            }
            set
            {
                this._playing = value;
                OnPropertyNameChanged(nameof(IsPlaying));
            } 
        }

        private string _nameOne = "Player one";
        public string PlayerOneName {
            get
            {
                return this._nameOne;
            }
            set
            {
                this._nameOne = value;
                OnPropertyNameChanged(nameof(PlayerOneName));
            }
        }

        private string _whoWon = "asd";
        public string WhoWon
        {
            get
            {
                return this._whoWon;
            }
            set
            {
                this._whoWon = value;
                OnPropertyNameChanged(nameof(WhoWon));
            }
        }

        private string _nameTwo = "Player Two";
        public string PlayerTwoName
        {
            get
            {
                return this._nameTwo;
            }
            set
            {
                this._nameTwo = value;
                OnPropertyNameChanged(nameof(PlayerTwoName));
            }
        }
        public TicTacToeViewModel()
        {
            this._board = new Board();
            this._player1 = new Player('X', "Player One");
            this._player2 = new Player('O', "Player Two");
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyNameChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
            string Winner = "";
            //Marked = MarkPlayer.PlayerSymbol;
            nextPlayer.Mark(MarkPosition,this._board);
            Winner = _board.WhoIsTheWinner();
            if (Winner !=" ")
            {
                IsPlaying = false;
                TheWinnerIs(Winner);
            }
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

        private void TheWinnerIs(string Winner)
        {
            Player WinPlayer = GetNextPlayer(this._player1,this._player2);
            if (Winner == "Empate")
            {
                this.WhoWon = Winner;
                return;
            }
            if(WinPlayer == this._player1)
            {
                this.WhoWon = "El Ganador es: " + _nameTwo;
            }
            else
            {
                this.WhoWon = "El Ganador es: " + _nameOne;
            }

            

            
        }

        public void RestartGame()
        {
            this._board.ClearBoard();
            this.IsPlaying = true;
            this.ButtonsPlaying = true;
            this.ButtonContent = " ";
            
        }
    }
}
