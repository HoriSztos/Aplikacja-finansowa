using AplikacjaFinansowa;
using System;
using System.Windows.Forms;

namespace AplikacjaFinansowa
{
    public partial class DodajTransakcjeForm : Form
    {
        private MainForm mainForm;


        public DodajTransakcjeForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            // Pobieramy dane z formularza i tworzymy nową transakcję
            string typ = comboBoxTyp.Text;
            decimal kwota = decimal.Parse(textBoxKwota.Text);
            DateTime data = dateTimePickerData.Value;

            Transakcja nowaTransakcja = new Transakcja
            {
                Typ = typ,
                Kwota = kwota,
                Data = data
            };

            // Dodajemy nową transakcję do bazy danych
            mainForm.DodajTransakcje(nowaTransakcja);

            // Zamykamy formularz
            this.Close();
        }
    }
}
