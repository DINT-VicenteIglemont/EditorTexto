using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica de interacción para EditorTexto.xaml
    /// </summary>
    public partial class NuevoDocumento : Window
    {
        public NuevoDocumento()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dialogo = new Microsoft.Win32.SaveFileDialog();
            dialogo.Filter = "Archivos de texto|*.txt";
            dialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if(dialogo.ShowDialog() == true)
            {
                File.WriteAllText(dialogo.FileName, ContenidoTextBlock.Text);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(MessageBox.Show("¿Salir?", "Confirmacion", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
