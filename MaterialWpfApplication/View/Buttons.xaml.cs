using MaterialWpfApplication.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace MaterialWpfApplication.View
{
    /// <summary>
    /// Логика взаимодействия для Buttons.xaml
    /// </summary>
    public partial class Buttons : UserControl
    {
        public Buttons()
        {
            InitializeComponent();
            DataContext = new ButtonsViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(CountingBadge.Badge == null || Equals(CountingBadge.Badge, ""))
            {
                CountingBadge.Badge = 0;
            }

            var next = int.Parse(CountingBadge.Badge.ToString()) + 1;

            CountingBadge.Badge = next < 10 ? (object)next : null;
        }
        
    }
}
