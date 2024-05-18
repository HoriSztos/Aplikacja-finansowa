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
    public partial class Operacja : Form
    {
        private List<string> wydatkiKategorie = new List<string> { "Jedzenie", "Transport", "Mieszkanie", "Rozrywka" };
        private List<string> przychodyKategorie = new List<string> { "Wynagrodzenie", "Premia", "Zwrot", "Sprzedaż" };

        public Operacja()
        {
            InitializeComponent();
          
        }
       

       

        private void dodaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operacja dodana pomyślnie!", "Dodano", MessageBoxButtons.OK);
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
    }
}
