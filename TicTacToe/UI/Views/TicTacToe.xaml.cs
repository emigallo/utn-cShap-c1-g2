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
            this._viewmodel = new TicTacToeViewModel();
            DataContext = _viewmodel;
        }

        //Tenemos que corregir este metodo
        private void ButtonPress(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int ColumnPosition = (int)button.GetValue(Grid.ColumnProperty); //Devuelve la columna
            int RowPosition = (int)button.GetValue(Grid.RowProperty); //Devuelve la fila
            //this._viewmodel.Mark(RowPosition, ColumnPosition)
            button.IsEnabled = false;
            button.Content = _viewmodel.Mark(RowPosition, ColumnPosition);

        }
    }
}
