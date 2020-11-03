using System;
using System.Windows;
using System.Windows.Controls;

namespace UT3_Ac5_Calculadora
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBlock texto = (sender as Button).Tag.ToString();
            //textoSalidaTextBlock.Text += (sender as Button).Tag.ToString();
        }
    }
}
