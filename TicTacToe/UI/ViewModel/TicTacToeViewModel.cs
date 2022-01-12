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

        private List<bool> ButtonsPlaying = new List<bool> ();

        private List<string> ButtonsContent = new List<string> ();

        private string _buttonContent1 = " ";
        public string ButtonContent1 {
            get
            {
                return this._buttonContent1;
            }
            set
            {
                this._buttonContent1 = value;
                OnPropertyNameChanged(nameof(ButtonContent1));
            }
        }

        private string _buttonContent2 = " ";
        public string ButtonContent2
        {
            get
            {
                return this._buttonContent2;
            }
            set
            {
                this._buttonContent2 = value;
                OnPropertyNameChanged(nameof(ButtonContent2));
            }
        }

        private string _buttonContent3 = " ";
        public string ButtonContent3
        {
            get
            {
                return this._buttonContent3;
            }
            set
            {
                this._buttonContent3 = value;
                OnPropertyNameChanged(nameof(ButtonContent3));
            }
        }

        private string _buttonContent4 = " ";
        public string ButtonContent4
        {
            get
            {
                return this._buttonContent4;
            }
            set
            {
                this._buttonContent4 = value;
                OnPropertyNameChanged(nameof(ButtonContent4));
            }
        }

        private string _buttonContent5 = " ";
        public string ButtonContent5
        {
            get
            {
                return this._buttonContent5;
            }
            set
            {
                this._buttonContent5 = value;
                OnPropertyNameChanged(nameof(ButtonContent5));
            }
        }

        private string _buttonContent6 = " ";
        public string ButtonContent6
        {
            get
            {
                return this._buttonContent6;
            }
            set
            {
                this._buttonContent6 = value;
                OnPropertyNameChanged(nameof(ButtonContent6));
            }
        }

        private string _buttonContent7 = " ";
        public string ButtonContent7
        {
            get
            {
                return this._buttonContent7;
            }
            set
            {
                this._buttonContent7 = value;
                OnPropertyNameChanged(nameof(ButtonContent7));
            }
        }

        private string _buttonContent8 = " ";
        public string ButtonContent8
        {
            get
            {
                return this._buttonContent8;
            }
            set
            {
                this._buttonContent8 = value;
                OnPropertyNameChanged(nameof(ButtonContent8));
            }
        }

        private string _buttonContent9 = " ";
        public string ButtonContent9
        {
            get
            {
                return this._buttonContent9;
            }
            set
            {
                this._buttonContent9 = value;
                OnPropertyNameChanged(nameof(ButtonContent9));
            }
        }

        private bool _buttonsPlaying1 = true;

        public bool ButtonsPlaying1 {
            get
            {
                return this._buttonsPlaying1;
            }
            set
            {
                this._buttonsPlaying1 = value;
                OnPropertyNameChanged(nameof(ButtonsPlaying1));
            }
        }

        private bool _buttonsPlaying2 = true;

        public bool ButtonsPlaying2
        {
            get
            {
                return this._buttonsPlaying2;
            }
            set
            {
                this._buttonsPlaying2 = value;
                OnPropertyNameChanged(nameof(ButtonsPlaying2));
            }
        }

        private bool _buttonsPlaying3 = true;

        public bool ButtonsPlaying3
        {
            get
            {
                return this._buttonsPlaying3;
            }
            set
            {
                this._buttonsPlaying3 = value;
                OnPropertyNameChanged(nameof(ButtonsPlaying3));
            }
        }

        private bool _buttonsPlaying4 = true;

        public bool ButtonsPlaying4
        {
            get
            {
                return this._buttonsPlaying4;
            }
            set
            {
                this._buttonsPlaying4 = value;
                OnPropertyNameChanged(nameof(ButtonsPlaying4));
            }
        }

        private bool _buttonsPlaying5 = true;

        public bool ButtonsPlaying5
        {
            get
            {
                return this._buttonsPlaying5;
            }
            set
            {
                this._buttonsPlaying5 = value;
                OnPropertyNameChanged(nameof(ButtonsPlaying5));
            }
        }

        private bool _buttonsPlaying6 = true;
        public bool ButtonsPlaying6
        {
            get
            {
                return this._buttonsPlaying6;
            }
            set
            {
                this._buttonsPlaying6 = value;
                OnPropertyNameChanged(nameof(ButtonsPlaying6));
            }
        }

        private bool _buttonsPlaying7 = true;
        public bool ButtonsPlaying7
        {
            get
            {
                return this._buttonsPlaying7;
            }
            set
            {
                this._buttonsPlaying7 = value;
                OnPropertyNameChanged(nameof(ButtonsPlaying7));
            }
        }

        private bool _buttonsPlaying8 = true;
        public bool ButtonsPlaying8
        {
            get
            {
                return this._buttonsPlaying8;
            }
            set
            {
                this._buttonsPlaying8 = value;
                OnPropertyNameChanged(nameof(ButtonsPlaying8));
            }
        }

        private bool _buttonsPlaying9 = true;
        public bool ButtonsPlaying9
        {
            get
            {
                return this._buttonsPlaying9;
            }
            set
            {
                this._buttonsPlaying9 = value;
                OnPropertyNameChanged(nameof(ButtonsPlaying9));
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

        public void Mark(int Row,int Column)
        {
            Player nextPlayer = GetNextPlayer(_player1, _player2);
            int MarkPosition = TransformCoordinates(Row, Column);
            
            string Winner = "";
            //Marked = MarkPlayer.PlayerSymbol;
            nextPlayer.Mark(MarkPosition,this._board);
            /*this.ButtonsPlaying1 = false;
            this.ButtonContent1 = "" + nextPlayer.PlayerSymbol;*/
            DisableButtonPlaying(MarkPosition,nextPlayer.PlayerSymbol);
            Winner = _board.WhoIsTheWinner();
            if (Winner !=" ")
            {
                IsPlaying = false;
                TheWinnerIs(Winner);
            }
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
            this.ButtonsPlaying1 = true;
            this.IsPlaying = true;
            this.ButtonContent1 = " ";
            this._board.ClearBoard();
            ReWriteSelected();
        }

        private void ReWriteSelected()
        {
            this.ButtonsPlaying1 = true;
            this.ButtonsPlaying2 = true;
            this.ButtonsPlaying3 = true;
            this.ButtonsPlaying4 = true;
            this.ButtonsPlaying5 = true;
            this.ButtonsPlaying6 = true;
            this.ButtonsPlaying7 = true;
            this.ButtonsPlaying8 = true;
            this.ButtonsPlaying9 = true;
            this.ButtonContent1 = " ";
            this.ButtonContent2 = " ";
            this.ButtonContent3 = " ";
            this.ButtonContent4 = " ";
            this.ButtonContent5 = " ";
            this.ButtonContent6 = " ";
            this.ButtonContent7 = " ";
            this.ButtonContent8 = " ";
            this.ButtonContent9 = " ";


        }

        private void DisableButtonPlaying(int position, char symbol)
        {
            switch (position)
            {
                case 1:
                    this.ButtonsPlaying1 = false;
                    this.ButtonContent1 = ""+symbol;
                    break;
                case 2:
                    this.ButtonsPlaying2 = false;
                    this.ButtonContent2 = "" + symbol;
                    break;
                case 3:
                    this.ButtonsPlaying3 = false;
                    this.ButtonContent3 = "" + symbol;
                    break;
                case 4:
                    this.ButtonsPlaying4 = false;
                    this.ButtonContent4 = "" + symbol;
                    break;
                case 5:
                    this.ButtonsPlaying5 = false;
                    this.ButtonContent5 = "" + symbol;
                    break;
                case 6:
                    this.ButtonsPlaying6 = false;
                    this.ButtonContent6 = "" + symbol;
                    break;
                case 7:
                    this.ButtonsPlaying7 = false;
                    this.ButtonContent7 = "" + symbol;
                    break;
                case 8:
                    this.ButtonsPlaying8 = false;
                    this.ButtonContent8 = "" + symbol;
                    break;
                case 9:
                    this.ButtonsPlaying9 = false;
                    this.ButtonContent9 = "" + symbol;
                    break;
            }


        }
    }
}
