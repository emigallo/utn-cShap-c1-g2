using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UI.ViewModel;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TicTacToe : Window
    {
        private TicTacToeViewModel _viewmodel;
        public TicTacToe()
        {
            InitializeComponent();
            _viewmodel = new TicTacToeViewModel();
            DataContext = _viewmodel;
        }

        private void ButtonPress(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            //Sumo uno en cada uno por que el grid empieza en 0
            int ColumnPosition = (int)button.GetValue(Grid.ColumnProperty); //Devuelve la columna
            int RowPosition = (int)button.GetValue(Grid.RowProperty); //Devuelve la fila
            int MarkPosition = _viewmodel.TransformCoordinates(RowPosition, ColumnPosition);
            //Tenemos que corregir este metodo


            //Falta llamar a la operacion marcar con las coordenadas y los valores que necesite
        }
    }
}
