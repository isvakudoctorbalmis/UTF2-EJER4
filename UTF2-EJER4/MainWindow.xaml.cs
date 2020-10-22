using System.Windows;
using System.Windows.Controls;


namespace UTF2_EJER4
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

        private void CaracteresTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CaracteresTextBox.AcceptsReturn = true;
            CaracteresTextBox.MaxLength = 140;
            if (CaracteresTextBox.Text.Length == 140)
                CaracteresTextBox.IsEnabled = false;
            contadorTextBlock.Text = CaracteresTextBox.Text.Length + " /  140";
        }
    }
}
