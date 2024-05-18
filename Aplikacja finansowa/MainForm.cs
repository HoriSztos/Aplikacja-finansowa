using AplikacjaFinansowa;
using System;
using System.Windows.Forms;

namespace AplikacjaFinansowa
{
    public partial class MainForm : Form
    {
        private ZarzadzanieTransakcjami zarzadzanieTransakcjami = new ZarzadzanieTransakcjami();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OdswiezListeTransakcji();
        }

        private void OdswiezListeTransakcji()
        {
            listViewTransakcje.Items.Clear();
            var transakcje = zarzadzanieTransakcjami.PobierzWszystkieTransakcje();
            foreach (var transakcja in transakcje)
            {
                string[] row = { transakcja.Id.ToString(), transakcja.Typ, transakcja.Kwota.ToString(), transakcja.Data.ToShortDateString() };
                var listViewItem = new ListViewItem(row);
                listViewTransakcje.Items.Add(listViewItem);
            }
        }

        private void btnDodajTransakcje_Click(object sender, EventArgs e)
        {
            DodajTransakcjeForm dodajTransakcjeForm = new DodajTransakcjeForm(this);
            dodajTransakcjeForm.ShowDialog();
        }

        public void DodajTransakcje(Transakcja transakcja)
        {
            zarzadzanieTransakcjami.DodajTransakcje(transakcja);
            OdswiezListeTransakcji();
        }
    }
}
