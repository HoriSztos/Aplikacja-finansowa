using System;
using System.Windows.Forms;
using Npgsql;


namespace Aplikacja_finansowa
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.MainMenu_Load);
            StyleManager.ApplyStylesToForm(this);
        }

        

        private void zarzadzaj_Click(object sender, EventArgs e)
        {
            Finanse finanse = new Finanse();
            this.Hide();
            finanse.FormClosed += (s, args) => this.Close();
            finanse.Show();
        }

        private void raporty_Click(object sender, EventArgs e)
        {
            Raporty raporty = new Raporty();
            this.Hide();
            raporty.FormClosed += (s, args) => this.Close();
            raporty.Show();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            Operacja operacja = new Operacja();
            this.Hide();
            operacja.FormClosed += (s, args) => this.Close();
            operacja.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                // Połączenie z bazą danych
                string connectionString = "Host=localhost;Username=postgres;Password=projekt;Database=postgres";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Zapytanie SQL
                    string query = "SELECT name, value FROM projekt.transactions";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("Brak danych.");
                            }
                            else
                            {
                                while (reader.Read())
                                {
                                    string name = reader["name"].ToString();
                                    string value = reader["value"].ToString();
                                    string displayText = $"{name}, {value}";
                                    listBox1.Items.Add(displayText);
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            PobierzSumy();
        }

        private void PobierzSumy()
        {
            try
            {
                // Połączenie z bazą danych
                string connectionString = "Host=localhost;Username=postgres;Password=projekt;Database=postgres";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Zapytanie SQL dla sumy wydatków od początku miesiąca
                    string queryWydatki = "SELECT SUM(value) FROM projekt.transactions WHERE category IN (SELECT * FROM projekt.categories_expenses) and \"date\" >= DATE_TRUNC('month', CURRENT_DATE) AND \"date\" <= CURRENT_DATE ";

                    // Zapytanie SQL dla sumy przychodów od początku miesiąca
                    string queryPrzychody = "SELECT SUM(value) FROM projekt.transactions WHERE category IN (SELECT * FROM projekt.categories_gains) and \"date\" >= DATE_TRUNC('month', CURRENT_DATE) AND \"date\" <= CURRENT_DATE ";

                    // Wykonanie zapytań i odczytanie wyników
                    decimal sumWydatki = 0;
                    decimal sumPrzychody = 0;

                    using (NpgsqlCommand commandWydatki = new NpgsqlCommand(queryWydatki, connection))
                    {
                        object result = commandWydatki.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            sumWydatki = Convert.ToDecimal(result);
                        }
                       
                    }

                    using (NpgsqlCommand commandPrzychody = new NpgsqlCommand(queryPrzychody, connection))
                    {
                        object result = commandPrzychody.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            sumPrzychody = Convert.ToDecimal(result);
                        }
                    }

                    DateTime dzisiaj = DateTime.Now;
                    podsumowanie.Text = $"Dziś jest {dzisiaj:dd.MM.yyyy}. \nPodsumowanie transakcji od początku miesiąca: \nWydatki: {sumWydatki:C}\nPrzychody: {sumPrzychody:C}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    
        
    }
}