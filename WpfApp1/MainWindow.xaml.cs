using System.Windows;

namespace WpfApp1
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

        private void saludarButton_Click(object sender, RoutedEventArgs e)
        {
            if (nombreTextBox.Text.Length == 0)
                saludoTextBlock.Text = "Hola mundo!";
            else
                saludoTextBlock.Text = $"Hola {nombreTextBox.Text}!";
        }
    }
}
