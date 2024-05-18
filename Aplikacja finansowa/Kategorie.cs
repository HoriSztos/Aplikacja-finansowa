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
        private List<string> wydatkiKategorie = new List<string> { "Jedzenie", "Transport", "Mieszkanie", "Rozrywka" };
        private List<string> przychodyKategorie = new List<string> { "Wynagrodzenie", "Premia", "Zwrot", "Sprzedaż" };

   
        public Kategorie()
        {
            InitializeComponent();
            InitializeCategoryLists();
        }

        private void InitializeCategoryLists()
        {
            // Dodaj istniejące kategorie do listboxów
            foreach (string category in wydatkiKategorie)
            {
                kategorieWydatków.Items.Add(category);
            }

            foreach (string category in przychodyKategorie)
            {
                kategoriePrzychodów.Items.Add(category);
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
                wydatkiKategorie.Remove(selectedCategory);
                kategorieWydatków.Items.RemoveAt(kategorieWydatków.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Wybierz kategorię do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dodaj_wyd_Click(object sender, EventArgs e)
        {
            string newCategory = dodaj_kategorie_wydatku.Text.Trim();
            if (!string.IsNullOrEmpty(newCategory))
            {
                wydatkiKategorie.Add(newCategory);
                kategorieWydatków.Items.Add(newCategory);
                dodaj_kategorie_wydatku.Clear();
            }
            else
            {
                MessageBox.Show("Wprowadź nazwę kategorii.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
