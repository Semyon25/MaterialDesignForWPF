using System.Windows.Controls;
using MaterialWpfApplication.ViewModel;

namespace MaterialWpfApplication.View
{
    /// <summary>
    /// Логика взаимодействия для Chips.xaml
    /// </summary>
    public partial class Chips : UserControl
    {
        public Chips()
        {
            InitializeComponent();
            DataContext = new ChipsViewModel();
        }
    }
}
