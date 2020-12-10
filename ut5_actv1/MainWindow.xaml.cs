using Comida;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace ut5_actv1
{
    public partial class MainWindow : Window
    {
        ObservableCollection<Plato> platos;
        public MainWindow()
        {
            InitializeComponent();
            string[] tiposPlatos =  { "Americana", "Mexicana", "China" };
            string rutaActual = System.IO.Path.GetFullPath("..\\..\\");
            platos = new ObservableCollection<Plato>(Plato.GetSamples(rutaActual + @"\Imagenes"));
            listaPlatos.DataContext = platos;
            tipoComidaComboBox.ItemsSource = tiposPlatos;
        }

        private void ListaPlatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            camposPlatos.DataContext = (Plato)listaPlatos.SelectedItem;
            tipoComidaComboBox.DataContext = (Plato)listaPlatos.SelectedItem;
        }
    }
}
