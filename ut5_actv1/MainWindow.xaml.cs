using Comida;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ut5_actv1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Plato> platos;
        public MainWindow()
        {
            InitializeComponent();
            string rutaActual = System.IO.Path.GetFullPath("..\\..\\");
            platos = new ObservableCollection<Plato>(Plato.GetSamples(rutaActual+@"\Imagenes"));
            listaPlatos.DataContext = platos;
        }

        private void ListaPlatos_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if ((Plato)listaPlatos.SelectedItem != null)
            {
                camposPlatos.DataContext = (Plato)listaPlatos.SelectedItem;
                tipoComidaComboBox.Text = ((Plato)listaPlatos.SelectedItem).Tipo;
            }
            
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            (listaPlatos.SelectedItem as Plato).Tipo = (sender as ComboBoxItem).Content.ToString();
        }
    }
}
