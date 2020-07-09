using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace MaterialWpfApplication.View
{
    /// <summary>
    /// Логика взаимодействия для MenusAndToolBars.xaml
    /// </summary>
    public partial class MenusAndToolBars : UserControl
    {
        public MenusAndToolBars()
        {
            InitializeComponent();
        }

        private void TwitterButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://twitter.com");
        }
    }
}
