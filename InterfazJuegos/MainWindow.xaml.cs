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

 
namespace InterfazJuegos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //inicializar el juego
            //Juego.dameElJuego
        }

        private void btn_Jugar_Click(object sender, RoutedEventArgs e)
        {
            var nombreJugador = txt_Jugador.Text;
            var continente = cmb_Continentes.SelectedItem;

            //Miro si el jugador existe, si no lo creo y lo recupero

            //Creo una partida a ese jugador

            // Llamo a la ventaja del juego
            GameWindow ventanaJuego = new GameWindow();
            ventanaJuego.Show();

        }
    }
}
