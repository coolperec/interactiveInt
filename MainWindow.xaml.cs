using System.Windows;

namespace WpfAppDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RedBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = System.Windows.Media.Brushes.Red;
            StatusBarItem1.Content = "Фон изменён на красный";
        }

        private void GreenBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = System.Windows.Media.Brushes.Green;
            StatusBarItem1.Content = "Фон изменён на зелёный";
        }

        private void BlueBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = System.Windows.Media.Brushes.Blue;
            StatusBarItem1.Content = "Фон изменён на синий";
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Никитин Ярослав\nВерсия: 1.0", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
