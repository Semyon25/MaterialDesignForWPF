using System.Windows.Controls;
using MaterialWpfApplication.ViewModel;

namespace MaterialWpfApplication.View
{
    /// <summary>
    /// Логика взаимодействия для Lists.xaml
    /// </summary>
    public partial class Lists : UserControl
    {
        public Lists()
        {
            InitializeComponent();
            DataContext = new ListsAndGridsViewModel();
        }
    }
}
