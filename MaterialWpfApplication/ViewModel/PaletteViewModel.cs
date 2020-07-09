using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using MaterialWpfApplication.Helpers;
using System.Collections.Generic;
using System.Windows.Input;

namespace MaterialWpfApplication.ViewModel
{
    public class PaletteViewModel : ObservableObject
    {
        public IEnumerable<Swatch> Swatches { get; set; }

        public PaletteViewModel()
        {
            Swatches = new SwatchesProvider().Swatches;
        }

        public ICommand SetThemeCommand
        {
            get
            {
                return new DelegateCommand(o => ChangeTheme((bool)o));
            }
        }

        private void ChangeTheme(bool IsDark)
        {
            new PaletteHelper().SetLightDark(IsDark);
        }

        public ICommand ApplyPrimaryCommand { get; } = new DelegateCommand(o => ApplyPrimary((Swatch)o));

        public ICommand ApplyAccentCommand { get; } = new DelegateCommand(o => ApplyAccent((Swatch)o));

        private static void ApplyPrimary(Swatch swatch)
        {
            new PaletteHelper().ReplacePrimaryColor(swatch);
        }

        private static void ApplyAccent(Swatch swatch)
        {
            new PaletteHelper().ReplaceAccentColor(swatch);
        }

    }
}
