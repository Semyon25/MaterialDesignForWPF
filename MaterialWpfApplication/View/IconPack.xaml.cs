using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MaterialWpfApplication.ViewModel;

namespace MaterialWpfApplication.View
{
    /// <summary>
    /// Логика взаимодействия для IconPack.xaml
    /// </summary>
    public partial class IconPack : UserControl
    {
        public IconPack()
        {
            InitializeComponent();
            DataContext = new IconPackViewModel();
        }

        private void TextBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.Dispatcher.BeginInvoke(new Action(textBox.SelectAll));
        }

        private void Search_OnKeyDown(object sender, KeyEventArgs e)
        {
            var textBox = (TextBox)sender;
            if (e.Key == Key.Enter)
                SearchButton.Command.Execute(textBox.Text);
        }
    }
}
