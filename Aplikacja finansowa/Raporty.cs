using Npgsql;
using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
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
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Ustawienie kontekstu licencyjnego
            StyleManager.ApplyStylesToForm(this);
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
            data_koncowa.Text = $"Wybrana data końcowa: {today.ToShortDateString()}";
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

        private void generuj_Click(object sender, EventArgs e)
        {
            if (startDate.HasValue && endDate.HasValue)
            {
                DataTable data = GetData(startDate.Value, endDate.Value);
                GenerateExcelFile(data, startDate.Value, endDate.Value);
            }
            else
            {
                MessageBox.Show("Proszę wybrać zakres dat.");
            }
        }

        private DataTable GetData(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();

            string connectionString = "Host=localhost;Username=postgres;Password=projekt;Database=postgres";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT category, name, description, value FROM projekt.transactions WHERE date >= @startDate AND date <= @endDate";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("startDate", startDate);
                    command.Parameters.AddWithValue("endDate", endDate);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        private void GenerateExcelFile(DataTable data, DateTime startDate, DateTime endDate)
        {
            using (var excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Raport");

                // Dodanie nagłówków kolumn
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = data.Columns[i].ColumnName;
                }

                // Dodanie wierszy danych
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    for (int j = 0; j < data.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = data.Rows[i][j];
                    }
                }

                // Zapisanie pliku w wybranej lokalizacji
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"Raport_{startDate.ToString("yyyyMMdd")}_to_{endDate.ToString("yyyyMMdd")}.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        File.WriteAllBytes(filePath, excelPackage.GetAsByteArray());
                        MessageBox.Show($"Raport został wygenerowany: {filePath}");
                    }
                }
            }
        }
    }
}
