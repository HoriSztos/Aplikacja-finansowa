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
    public partial class Finanse : Form
    {
        public Finanse()
        {
            InitializeComponent();
            LoadKoszty();
            LoadPrzychody();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.FormClosed += (s, args) => this.Close();
            mainMenu.Show();

        }
        private void LoadKoszty()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=projekt;Database=postgres";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT category, name, description, value FROM projekt.transactions WHERE category IN (SELECT * FROM projekt.categories_expenses)";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        listViewKoszty.Items.Clear();
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["category"].ToString());
                            item.SubItems.Add(reader["name"].ToString());
                            item.SubItems.Add(reader["description"].ToString());
                            item.SubItems.Add(reader["value"].ToString());
                            listViewKoszty.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void LoadPrzychody()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=projekt;Database=postgres";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT category, name, description, value FROM projekt.transactions WHERE category IN (SELECT * FROM projekt.categories_gains)";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        listViewPrzychody.Items.Clear();
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["category"].ToString());
                            item.SubItems.Add(reader["name"].ToString());
                            item.SubItems.Add(reader["description"].ToString());
                            item.SubItems.Add(reader["value"].ToString());
                            listViewPrzychody.Items.Add(item);
                        }
                    }
                }
            }
        }
    }
}
