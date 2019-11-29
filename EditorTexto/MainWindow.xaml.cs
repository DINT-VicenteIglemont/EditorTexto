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

namespace EditorTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public int Ancho { get; set; } = 800;
        public int Alto { get; set; } = 450;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NuevoDocumentoButton_Click(object sender, RoutedEventArgs e)
        {
            NuevoDocumento editorTexto = new NuevoDocumento();
            editorTexto.Owner = this;
            editorTexto.Title += " " + this.OwnedWindows.Count;
            editorTexto.Width = Ancho;
            editorTexto.Height = Alto;
            editorTexto.Show();
        }

        private void ConfiguracionButton_Click(object sender, RoutedEventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Owner = this;
            configuracion.Show();
        }
    }
}
