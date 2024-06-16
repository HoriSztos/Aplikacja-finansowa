using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aplikacja_finansowa
{
    public static class StyleManager
    {
        public static void ApplyStyle(Control control)
        {
            // Przykład ustawienia stylu dla przycisku
            if (control is Button button)
            {
                button.BackColor = Color.SteelBlue;
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                button.FlatAppearance.BorderSize = 0;
            }

            // Przykład ustawienia stylu dla TextBox
            if (control is TextBox textBox)
            {
                textBox.BackColor = Color.LightGray;
                textBox.ForeColor = Color.MidnightBlue;
                textBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            }

            // Dodaj inne typy kontrolek i ich style
            if (control is Label label)
            {
                label.ForeColor = Color.MidnightBlue;
                label.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            }

            // Przykład ustawienia stylu dla ListBox
            if (control is ListBox listBox)
            {
                listBox.BackColor = Color.LightGray;
                listBox.ForeColor = Color.MidnightBlue;
                listBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            }
        }

        public static void ApplyStylesToForm(Form form)
        {
            form.BackColor = Color.FromArgb(230, 230, 250); // Bardzo jasnoniebieskie tło
            form.Font = new Font("Segoe UI", 10); // Domyślna czcionka

            foreach (Control control in form.Controls)
            {
                ApplyStyle(control);
                if (control.HasChildren)
                {
                    ApplyStylesToChildren(control);
                }
            }
        }

        private static void ApplyStylesToChildren(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                ApplyStyle(control);
                if (control.HasChildren)
                {
                    ApplyStylesToChildren(control);
                }
            }
        }
    }
}
