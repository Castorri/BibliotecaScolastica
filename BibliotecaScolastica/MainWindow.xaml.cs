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

namespace BibliotecaScolastica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    //aggiunta commento da github
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void creaBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            biblioteca biblioteca = new biblioteca(txtNomeBib.ToString(), txtIndirizzoBib.ToString(), txtAperturaBib.ToString(), txtChiusuraBib.ToString());
        }

        private void creaLibri_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
