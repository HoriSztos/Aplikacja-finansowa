using System.Drawing;
using System.Windows.Forms;

namespace Aplikacja_finansowa
{
    partial class Operacja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operacja));
            this.back = new System.Windows.Forms.Button();
            this.tytuł = new System.Windows.Forms.TextBox();
            this.kategoria = new System.Windows.Forms.ComboBox();
            this.typ = new System.Windows.Forms.ComboBox();
            this.dodaj = new System.Windows.Forms.Button();
            this.opis = new System.Windows.Forms.TextBox();
            this.kategorie = new System.Windows.Forms.Button();
            this.kwota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.SteelBlue;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(13, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(86, 29);
            this.back.TabIndex = 2;
            this.back.Text = "Powrót";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // tytuł
            // 
            this.tytuł.Location = new System.Drawing.Point(35, 74);
            this.tytuł.Multiline = true;
            this.tytuł.Name = "tytuł";
            this.tytuł.Size = new System.Drawing.Size(209, 19);
            this.tytuł.TabIndex = 3;
            this.tytuł.Text = "Tytuł";
            // 
            // kategoria
            // 
            this.kategoria.FormattingEnabled = true;
            this.kategoria.Location = new System.Drawing.Point(35, 143);
            this.kategoria.Name = "kategoria";
            this.kategoria.Size = new System.Drawing.Size(209, 21);
            this.kategoria.TabIndex = 4;
            this.kategoria.Text = "Kategoria";
            // 
            // typ
            // 
            this.typ.AutoCompleteCustomSource.AddRange(new string[] {
            "Przychód",
            "Koszt",
            "Inne"});
            this.typ.FormattingEnabled = true;
            this.typ.Location = new System.Drawing.Point(35, 107);
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(209, 21);
            this.typ.TabIndex = 5;
            this.typ.Text = "Typ";
            // 
            // dodaj
            // 
            this.dodaj.BackColor = System.Drawing.Color.SteelBlue;
            this.dodaj.FlatAppearance.BorderSize = 0;
            this.dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodaj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dodaj.ForeColor = System.Drawing.Color.White;
            this.dodaj.Location = new System.Drawing.Point(75, 305);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(120, 32);
            this.dodaj.TabIndex = 6;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = false;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // opis
            // 
            this.opis.Location = new System.Drawing.Point(35, 212);
            this.opis.Multiline = true;
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(209, 71);
            this.opis.TabIndex = 7;
            this.opis.Text = "Opis";
            // 
            // kategorie
            // 
            this.kategorie.BackColor = System.Drawing.Color.SteelBlue;
            this.kategorie.FlatAppearance.BorderSize = 0;
            this.kategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kategorie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kategorie.ForeColor = System.Drawing.Color.White;
            this.kategorie.Location = new System.Drawing.Point(301, 135);
            this.kategorie.Name = "kategorie";
            this.kategorie.Size = new System.Drawing.Size(206, 29);
            this.kategorie.TabIndex = 8;
            this.kategorie.Text = "Edytuj kategorie";
            this.kategorie.UseVisualStyleBackColor = false;
            this.kategorie.Click += new System.EventHandler(this.kategorie_Click);
            // 
            // kwota
            // 
            this.kwota.Location = new System.Drawing.Point(35, 180);
            this.kwota.Name = "kwota";
            this.kwota.Size = new System.Drawing.Size(209, 20);
            this.kwota.TabIndex = 9;
            this.kwota.Text = "Kwota";
            // 
            // Operacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(635, 367);
            this.Controls.Add(this.kwota);
            this.Controls.Add(this.kategorie);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.typ);
            this.Controls.Add(this.kategoria);
            this.Controls.Add(this.tytuł);
            this.Controls.Add(this.back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Operacja";
            this.Text = "Operacja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button back;
        public System.Windows.Forms.TextBox tytuł;
        public System.Windows.Forms.ComboBox kategoria;
        public System.Windows.Forms.ComboBox typ;
        public System.Windows.Forms.Button dodaj;
        public System.Windows.Forms.TextBox opis;
        public System.Windows.Forms.Button kategorie;
        public System.Windows.Forms.TextBox kwota;
    }
}