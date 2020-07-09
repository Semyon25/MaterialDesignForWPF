using System.Windows;
using System.Linq;
using MaterialWpfApplication.Helpers;

namespace MaterialWpfApplication.ViewModel
{
    public class MainWindowViewModel
    {
        MainWindow window = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        #region Command

        public DelegateCommand OpenPaletteCommand { get; set; }

        public DelegateCommand OpenButtonsCommand { get; set; }

        public DelegateCommand OpenTextFieldsCommand { get; set; }

        public DelegateCommand OpenPickersCommand { get; set; }
        public DelegateCommand OpenSlidersCommand { get; set; }
        public DelegateCommand OpenChipsCommand { get; set; }

        public DelegateCommand OpenTypographyCommand { get; set; }
        public DelegateCommand OpenShadowsCommand { get; set; }

        public DelegateCommand OpenCardsCommand { get; set; }
        public DelegateCommand OpenIconPackCommand { get; set; }
        public DelegateCommand OpenColorZoneCommand { get; set; }

        public DelegateCommand OpenListsCommand { get; set; }
        public DelegateCommand OpenTreesCommand { get; set; }
        public DelegateCommand OpenGridsCommand { get; set; }

        public DelegateCommand OpenExpandersCommand { get; set; }
        public DelegateCommand OpenGroupBoxesCommand { get; set; }

        public DelegateCommand OpenMenusAndToolbarsCommand { get; set; }

        public DelegateCommand OpenProgressBarCommand { get; set; }
        public DelegateCommand OpenDialogsCommand { get; set; }
        public DelegateCommand OpenTransitionsCommand { get; set; }

        public DelegateCommand OpenSnackbarsCommand { get; set; }
        public DelegateCommand OpenDrawersCommand { get; set; }

        #endregion

        public MainWindowViewModel()
        {
            OpenPaletteCommand = new DelegateCommand(o => OpenPalette());
            OpenButtonsCommand = new DelegateCommand(o => OpenButtons());
            OpenTextFieldsCommand = new DelegateCommand(o => OpenTextFields());

            OpenPickersCommand = new DelegateCommand(o => OpenPickers());
            OpenSlidersCommand = new DelegateCommand(o => OpenSliders());
            OpenChipsCommand = new DelegateCommand(o => OpenChips());

            OpenTypographyCommand = new DelegateCommand(o => OpenTypography());
            OpenShadowsCommand = new DelegateCommand(o => OpenShadows());

            OpenCardsCommand = new DelegateCommand(o => OpenCards());
            OpenIconPackCommand = new DelegateCommand(o => OpenIconPack());
            OpenColorZoneCommand = new DelegateCommand(o => OpenColorZone());

            OpenListsCommand = new DelegateCommand(o => OpenLists());
            OpenTreesCommand = new DelegateCommand(o => OpenTrees());
            OpenGridsCommand = new DelegateCommand(o => OpenGrids());

            OpenExpandersCommand = new DelegateCommand(o => OpenExpanders());
            OpenGroupBoxesCommand = new DelegateCommand(o => OpenGroupBoxes());

            OpenMenusAndToolbarsCommand = new DelegateCommand(o => OpenMenusAndToolbars());

            OpenProgressBarCommand = new DelegateCommand(o => OpenProgressBar());
            OpenDialogsCommand = new DelegateCommand(o => OpenDialogs());
            OpenTransitionsCommand = new DelegateCommand(o => OpenTransitions());

            OpenSnackbarsCommand = new DelegateCommand(o => OpenSnackbars());
            OpenDrawersCommand = new DelegateCommand(o => OpenDrawers());
        }

        #region Command implementation

        private void OpenPalette()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Palette());
        }

        private void OpenButtons()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Buttons());
        }

        private void OpenTextFields()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.TextFields());
        }

        private void OpenPickers()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Pickers());
        }

        private void OpenSliders()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Sliders());
        }

        private void OpenChips()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Chips());
        }

        private void OpenTypography()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Typography());
        }

        private void OpenShadows()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Shadows());
        }

        private void OpenCards()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Cards());
        }

        private void OpenIconPack()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.IconPack());
        }

        private void OpenColorZone()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.ColorZone());
        }

        private void OpenLists()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Lists());
        }

        private void OpenTrees()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Trees());
        }

        private void OpenGrids()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Grids());
        }

        private void OpenExpanders()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Expanders());
        }

        private void OpenGroupBoxes()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.GroupBoxes());
        }

        private void OpenMenusAndToolbars()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.MenusAndToolBars());
        }

        private void OpenProgressBar()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.ProgressBar());
        }

        private void OpenDialogs()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Dialogs());
        }

        private void OpenTransitions()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Transitions());
        }

        private void OpenSnackbars()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Snackbars());
        }

        private void OpenDrawers()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Drawers());
        }


        #endregion

    }
}
