using System.Windows;
using System.Windows.Controls;

namespace MaterialWpfApplication.TransitionsWindow
{
    /// <summary>
    /// Логика взаимодействия для Slide6_Origins.xaml
    /// </summary>
    public partial class Slide6_Origins : UserControl
    {
        public Slide6_Origins()
        {
            InitializeComponent();
        }

        private void FirstSlideButton_OnClick(object sender, RoutedEventArgs e)
        {
            Transitioner.SelectedIndex = 0;
        }

        private void SecondSlideButton_OnClick(object sender, RoutedEventArgs e)
        {
            Transitioner.SelectedIndex = 1;
        }
    }
}
