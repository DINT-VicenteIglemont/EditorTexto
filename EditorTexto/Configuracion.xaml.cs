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
using System.Windows.Shapes;

namespace EditorTexto
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void GuardarConfigButton_Click(object sender, RoutedEventArgs e)
        {
            
            (Owner as MainWindow).Alto = Convert.ToInt32(AltoTextBox.Text);
            (Owner as MainWindow).Ancho = Convert.ToInt32(AnchoTextBox.Text);

            Close();
        }

        private void CancelarConfigButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
