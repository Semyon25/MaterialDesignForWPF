using MaterialWpfApplication.Helpers;
using System.Windows;

namespace MaterialWpfApplication.ViewModel
{
    public class ButtonsViewModel
    {
        public DelegateCommand OpenPopupBoxCommand { get; set; }

        public DelegateCommand ClosePopupBoxCommand { get; set; }

        public ButtonsViewModel()
        {
            OpenPopupBoxCommand = new DelegateCommand(o => OpenPopupBox());

            ClosePopupBoxCommand = new DelegateCommand(o => ClosePopupBox());
        }

        private void OpenPopupBox()
        {
            MessageBox.Show("Opened popup box");
        }

        private void ClosePopupBox()
        {
            MessageBox.Show("Closed popup box");
        }

    }
}
