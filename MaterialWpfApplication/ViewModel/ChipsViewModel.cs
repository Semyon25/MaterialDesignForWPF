using System.Windows;
using MaterialWpfApplication.Helpers;

namespace MaterialWpfApplication.ViewModel
{
    public class ChipsViewModel
    {
        public DelegateCommand OpenChip { get; set; }

        public DelegateCommand CloseChip { get; set; }

        public ChipsViewModel()
        {
            OpenChip = new DelegateCommand(o => { MessageBox.Show("Chip clicked."); });

            CloseChip = new DelegateCommand(o => { MessageBox.Show("Chip delete clicked."); });
        }
    }
}
