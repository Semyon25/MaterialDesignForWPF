using System.Windows.Controls;
using MaterialWpfApplication.ViewModel;

namespace MaterialWpfApplication.View
{
    /// <summary>
    /// Логика взаимодействия для Grids.xaml
    /// </summary>
    public partial class Grids : UserControl
    {
        public Grids()
        {
            InitializeComponent();
            DataContext = new ListsAndGridsViewModel();
        }
    }
}
