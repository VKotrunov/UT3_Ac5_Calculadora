using System.Windows;
using System.Windows.Controls;

namespace UT3_Ac5_Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textoSalidaTextBlock.Text += (sender as Button).Tag.ToString();
        }
    }
}
