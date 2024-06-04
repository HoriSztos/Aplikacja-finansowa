using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace Aplikacja_finansowa
{
    public partial class MainMenu : Form
    {
         public MainMenu()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.MainMenu_Load);
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
                                MessageBox.Show("No data found.");
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
        }
    }
}