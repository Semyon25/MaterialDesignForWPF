﻿using System.Globalization;
using System.Linq;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;
using MaterialWpfApplication.ViewModel;

namespace MaterialWpfApplication.View
{
    /// <summary>
    /// Логика взаимодействия для Pickers.xaml
    /// </summary>
    public partial class Pickers : UserControl
    {
        public Pickers()
        {
            InitializeComponent();
            DataContext = new PickersViewModel();

            FutureDatePicker.BlackoutDates.AddDatesInPast();
            LoadLocales();
            LocaleCombo.SelectionChanged += LocaleCombo_SelectionChanged;
            LocaleCombo.SelectedItem = "uk-UA";
        }

        private void LocaleCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var lang = System.Windows.Markup.XmlLanguage.GetLanguage((string)LocaleCombo.SelectedItem);
            LocaleDatePicker.Language = lang;
            LocaleDatePickerRTL.Language = lang;

            //HACK: The calendar only refresh when we change the date
            LocaleDatePicker.DisplayDate = LocaleDatePicker.DisplayDate.AddDays(1);
            LocaleDatePicker.DisplayDate = LocaleDatePicker.DisplayDate.AddDays(-1);
            LocaleDatePickerRTL.DisplayDate = LocaleDatePicker.DisplayDate.AddDays(1);
            LocaleDatePickerRTL.DisplayDate = LocaleDatePicker.DisplayDate.AddDays(-1);
        }

        private void LoadLocales()
        {
            foreach (var ci in CultureInfo.GetCultures(CultureTypes.AllCultures)
                .Where(ci => ci.Calendar is GregorianCalendar)
                .OrderBy(ci => ci.Name))
            {
                LocaleCombo.Items.Add(ci.Name);
            }
        }

        public void CalendarDialogOpenedEventHandler(object sender, DialogOpenedEventArgs eventArgs)
        {
            Calendar.SelectedDate = ((PickersViewModel)DataContext).Date;
        }

        public void CalendarDialogClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            if (!Equals(eventArgs.Parameter, "1")) return;

            if (!Calendar.SelectedDate.HasValue)
            {
                eventArgs.Cancel();
                return;
            }

            ((PickersViewModel)DataContext).Date = Calendar.SelectedDate.Value;
        }

        public void ClockDialogOpenedEventHandler(object sender, DialogOpenedEventArgs eventArgs)
        {
            Clock.Time = ((PickersViewModel)DataContext).Time;
        }

        public void ClockDialogClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            if (Equals(eventArgs.Parameter, "1"))
                ((PickersViewModel)DataContext).Time = Clock.Time;
        }
    }
}
