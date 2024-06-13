using Npgsql;
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
    public partial class Kategorie : Form 
    {
        private List<string> wydatkiKategorie = new List<string> ();
        private List<string> przychodyKategorie = new List<string> ();

   
        public Kategorie()
        {
            InitializeComponent();
            InitializeCategoryLists();
        }

    private void InitializeCategoryLists()
    {

        try
        {
            // Połączenie z bazą danych
            string connectionString = "Host=localhost;Username=postgres;Password=projekt;Database=postgres";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string queryWydatki = "SELECT name FROM projekt.categories_expenses";
                using (NpgsqlCommand commandWydatki = new NpgsqlCommand(queryWydatki, connection))
                {
                    using (NpgsqlDataReader reader = commandWydatki.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            wydatkiKategorie.Add(reader["name"].ToString());
                        }
                    }
                }

                // Fetch categories for przychody
                string queryPrzychody = "SELECT name FROM projekt.categories_gains";
                using (NpgsqlCommand commandPrzychody = new NpgsqlCommand(queryPrzychody, connection))
                {
                    using (NpgsqlDataReader reader = commandPrzychody.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            przychodyKategorie.Add(reader["name"].ToString());
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Wystąpił błąd: {ex.Message}");
        }
        kategorieWydatków.Items.Clear();
        foreach (var category in wydatkiKategorie)
            {
                string item = category;
                kategorieWydatków.Items.Add(item);
            }
        kategoriePrzychodów.Items.Clear();
        foreach (var category in przychodyKategorie)
            {
                string item = category;
                kategoriePrzychodów.Items.Add(item);
            }
        }
        

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.FormClosed += (s, args) => this.Close();
            mainMenu.Show();
        }

        private void usun_wyd_Click(object sender, EventArgs e)
        {
            if (kategorieWydatków.SelectedIndex != -1)
            {
                string selectedCategory = kategorieWydatków.SelectedItem.ToString();
                UsunKategorieWydatkowZBazy(selectedCategory);
                wydatkiKategorie.Remove(selectedCategory);
                kategorieWydatków.Items.RemoveAt(kategorieWydatków.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Wybierz kategorię do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UsunKategorieWydatkowZBazy(string categoryName)
        {
            try
            {
                // Connection string
                string connectionString = "Host=localhost;Username=postgres;Password=projekt;Database=postgres";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Delete query
                    string query = "DELETE FROM projekt.categories_expenses WHERE name = @categoryName";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@categoryName", categoryName);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kategoria usunięta pomyślnie!", "Usunięto", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono kategorii do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }


        private void dodaj_wyd_Click(object sender, EventArgs e)
        {
            string category = dodaj_kategorie_wydatku.Text.Trim();
            if (!string.IsNullOrEmpty(category))
            {
                DodajKategorieWydatkowDoBazy(category);
                InitializeCategoryLists();
                dodaj_kategorie_wydatku.Clear();
            }
            else
            {
                MessageBox.Show("Wprowadź nazwę kategorii.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DodajKategorieWydatkowDoBazy(string category)
        {
            try
            {
                // Connection string
                string connectionString = "Host=localhost;Username=postgres;Password=projekt;Database=postgres";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert query
                    string query = "INSERT INTO projekt.categories_expenses\r\n(\"name\")\r\nVALUES(@category);";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@category", category);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kategoria dodana pomyślnie!", "Dodano", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }
        private void DodajKategoriePrzychodowDoBazy(string category)
        {
            try
            {
                // Connection string
                string connectionString = "Host=localhost;Username=postgres;Password=projekt;Database=postgres";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert query
                    string query = "INSERT INTO projekt.categories_gains\r\n(\"name\")\r\nVALUES(@category);";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@category", category);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kategoria dodana pomyślnie!", "Dodano", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }

        private void dod_przych_Click(object sender, EventArgs e)
        {
            string category = dodaj_kategorie_przychodu.Text.Trim();
            if (!string.IsNullOrEmpty(category))
            {
                DodajKategoriePrzychodowDoBazy(category);
                InitializeCategoryLists();
                dodaj_kategorie_przychodu.Clear();
            }
            else
            {
                MessageBox.Show("Wprowadź nazwę kategorii.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void usun_przych_Click(object sender, EventArgs e)
        {
            if (kategoriePrzychodów.SelectedIndex != -1)
            {
                string selectedCategory = kategoriePrzychodów.SelectedItem.ToString();
                UsunKategoriePrzychodowZBazy(selectedCategory);
                przychodyKategorie.Remove(selectedCategory);
                kategoriePrzychodów.Items.RemoveAt(kategoriePrzychodów.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Wybierz kategorię do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UsunKategoriePrzychodowZBazy(string categoryName)
        {
            try
            {
                // Connection string
                string connectionString = "Host=localhost;Username=postgres;Password=projekt;Database=postgres";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Delete query
                    string query = "DELETE FROM projekt.categories_gains WHERE name = @categoryName";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@categoryName", categoryName);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kategoria usunięta pomyślnie!", "Usunięto", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono kategorii do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }
    }
}
