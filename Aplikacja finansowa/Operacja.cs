using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplikacja_finansowa
{
    public partial class Operacja : Form
    {
        private List<string> wydatkiKategorie = new List<string> ();
        private List<string> przychodyKategorie = new List<string> ();

        public Operacja()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Operacja_Load);

        }


        private void Operacja_Load(object sender, EventArgs e)
        {
            try
            {
                // Połączenie z bazą danych
                string connectionString = "Host=localhost;Username=postgres;Password=projekt;Database=postgres";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch categories for wydatki
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
            typ.Items.Add("Wydatek");
            typ.Items.Add("Przychód");
            typ.SelectedIndexChanged += typ_SelectedIndexChanged;
            }
             
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

            private void dodaj_Click(object sender, EventArgs e)
        {
            string name =tytuł.Text.ToString();
            string description =opis.Text.ToString();
            string category =kategoria.Text.ToString();
            decimal value = decimal.Parse(kwota.Text);
            InsertTransaction(category, name, description, value);
        }

        private void kategorie_Click(object sender, EventArgs e)
        {
            Kategorie kategorie = new Kategorie();
            this.Hide();
            kategorie.FormClosed += (s, args) => this.Close();
            kategorie.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.FormClosed += (s, args) => this.Close();
            mainMenu.Show();
        }

        private void typ_SelectedIndexChanged(object sender, EventArgs e)
        {
            kategoria.Items.Clear();

            string selectedCategory = typ.SelectedItem.ToString();

           
            if (selectedCategory == "Wydatek")
            {
                kategoria.Items.AddRange(wydatkiKategorie.ToArray());
            }
            if (selectedCategory == "Przychód")
            {
                kategoria.Items.AddRange(przychodyKategorie.ToArray());
            }
        }
        private void InsertTransaction(string category, string name, string description, decimal value)
        {
            try
            {
                // Connection string
                string connectionString = "Host=localhost;Username=postgres;Password=projekt;Database=postgres";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert query
                    string query = "INSERT INTO projekt.transactions (category, name, description, value, id) VALUES (@category, @name, @description, @value, nextval('projekt.transactions_id_seq'::regclass))";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@category", category);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@value", value);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Operacja dodana pomyślnie!", "Dodano", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }
    }
}
