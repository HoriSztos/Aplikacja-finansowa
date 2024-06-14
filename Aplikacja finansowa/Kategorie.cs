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
            kategorieWydatków.Items.Clear();
            kategoriePrzychodów.Items.Clear();
            wydatkiKategorie.Clear();
            przychodyKategorie.Clear();

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
        
        foreach (var category in wydatkiKategorie)
            {
                string item = category;
                kategorieWydatków.Items.Add(item);
            }
        
        foreach (var category in przychodyKategorie)
            {
                string item = category;
                kategoriePrzychodów.Items.Add(item);
            }
        }
        

        private void back_Click(object sender, EventArgs e)
        {
            Operacja operacja = new Operacja();
            this.Hide();
            operacja.FormClosed += (s, args) => this.Close();
            operacja.Show();
        }

        private void usun_wyd_Click(object sender, EventArgs e)
        {
            if (kategorieWydatków.SelectedIndex != -1)
            {
                string selectedCategory = kategorieWydatków.SelectedItem.ToString();
                UsunKategorieWydatkowZBazy(selectedCategory);
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
                            InitializeCategoryLists();
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

                    // Sprawdź czy kategoria już istnieje w liście wydatkiKategorie
                    if (!wydatkiKategorie.Contains(category))
                    {
                        // Insert query
                        string query = "INSERT INTO projekt.categories_expenses (\"name\") VALUES (@category)";
                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@category", category);
                            command.ExecuteNonQuery();
                        }

                        // Dodaj kategorię tylko jeśli została dodana do bazy danych
                        wydatkiKategorie.Add(category);
                        MessageBox.Show("Kategoria dodana pomyślnie!", "Dodano", MessageBoxButtons.OK);
                        // Po dodaniu do bazy danych odśwież listy kategorii
                        InitializeCategoryLists();
                    }
                    else
                    {
                        MessageBox.Show("Kategoria już istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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

                    if (!przychodyKategorie.Contains(category))
                    {
                        // Insert query
                        string query = "INSERT INTO projekt.categories_gains (\"name\") VALUES (@category)";
                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@category", category);
                            command.ExecuteNonQuery();
                        }

                        przychodyKategorie.Add(category);
                        MessageBox.Show("Kategoria dodana pomyślnie!", "Dodano", MessageBoxButtons.OK);
                        InitializeCategoryLists();
                    }
                    else
                    {
                        MessageBox.Show("Kategoria już istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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
                            InitializeCategoryLists();
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
