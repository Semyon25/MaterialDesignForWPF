using System.Windows;
using System.Windows.Controls;
using MaterialWpfApplication.ViewModel;

namespace MaterialWpfApplication.View
{
    /// <summary>
    /// Логика взаимодействия для Trees.xaml
    /// </summary>
    public partial class Trees : UserControl
    {
        public Trees()
        {
            InitializeComponent();
            DataContext = new TreesViewModel();
        }

        public TreesViewModel ViewModel => DataContext as TreesViewModel;

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (ViewModel == null) return;

            ViewModel.SelectedItem = e.NewValue;
        }
    }
}
