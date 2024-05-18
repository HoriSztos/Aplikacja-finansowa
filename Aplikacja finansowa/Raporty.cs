using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_finansowa
{
    public partial class Raporty : Form
    {
        private DateTime? startDate = null;
        private DateTime? endDate = null;

        public Raporty()
        {
            InitializeComponent();
            monthCalendar1.DateSelected += new DateRangeEventHandler(MonthCalendar_DateSelected);
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (startDate == null)
            {
                startDate = e.Start;
                endDate = null;
                data_poczatek.Text = $"Wybrana data początkowa: {startDate.Value.ToShortDateString()}";
            }
            else if (endDate == null)
            {
                endDate = e.End;
                if (endDate < startDate)
                {
                    // Zamiana dat, jeśli użytkownik wybrał końcową datę wcześniej niż początkową
                    var temp = startDate;
                    startDate = endDate;
                    endDate = temp;
                }
                data_poczatek.Text = $"Wybrana data początkowa: {startDate.Value.ToShortDateString()}";
                data_koncowa.Text = $"Wybrana data końcowa: {endDate.Value.ToShortDateString()}";
                monthCalendar1.SetSelectionRange(startDate.Value, endDate.Value);
            }
            
            
           
        }


        private void back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.FormClosed += (s, args) => this.Close();
            mainMenu.Show();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            startDate = null;
            endDate = null;
            data_poczatek.Text = "Wybrana data początkowa: ";
            data_koncowa.Text = "Wybrana data końcowa: ";
        }

        private void tydzien_Click(object sender, EventArgs e)
        {
            // Obliczenie daty początkowej i końcowej ostatniego tygodnia
            DateTime today = DateTime.Today;
            DateTime startOfWeek = today.AddDays(-6);

            monthCalendar1.SetSelectionRange(startOfWeek, today);

            data_poczatek.Text = $"Wybrana data początkowa: {startOfWeek.ToShortDateString()}";
            data_koncowa.Text= $"Wybrana data końcowa: {today.ToShortDateString()}";
        }

        private void miesiac_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime startOfLastMonth = today.AddMonths(-1);
            DateTime endOfLastMonth = today.AddDays(-1);

            monthCalendar1.SetSelectionRange(startOfLastMonth, endOfLastMonth);

            data_poczatek.Text = $"Wybrana data początkowa: {startOfLastMonth.ToShortDateString()}";
            data_koncowa.Text = $"Wybrana data końcowa: {endOfLastMonth.ToShortDateString()}";
        }

        private void rok_Click(object sender, EventArgs e)
        {
            // Obliczenie daty początkowej i końcowej roku do dziś
            DateTime today = DateTime.Today;
            DateTime startOfYear = new DateTime(today.Year, 1, 1);
            DateTime endOfYear = today;

            monthCalendar1.SetSelectionRange(startOfYear, endOfYear);

            data_poczatek.Text = $"Wybrana data początkowa: {startOfYear.ToShortDateString()}";
            data_koncowa.Text = $"Wybrana data końcowa: {endOfYear.ToShortDateString()}";
        }
    }
}
