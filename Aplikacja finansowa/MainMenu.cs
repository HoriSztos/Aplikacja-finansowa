using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Aplikacja_finansowa
{
    public partial class MainMenu : Form
    {
   

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
    }
}
