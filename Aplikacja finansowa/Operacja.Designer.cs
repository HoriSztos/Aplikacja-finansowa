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
            this.back = new System.Windows.Forms.Button();
            this.tytuł = new System.Windows.Forms.TextBox();
            this.kategoria = new System.Windows.Forms.ComboBox();
            this.typ = new System.Windows.Forms.ComboBox();
            this.dodaj = new System.Windows.Forms.Button();
            this.opis = new System.Windows.Forms.TextBox();
            this.kategorie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(81, 30);
            this.back.TabIndex = 2;
            this.back.Text = "Powrót";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // tytuł
            // 
            this.tytuł.Location = new System.Drawing.Point(33, 87);
            this.tytuł.Multiline = true;
            this.tytuł.Name = "tytuł";
            this.tytuł.Size = new System.Drawing.Size(196, 20);
            this.tytuł.TabIndex = 3;
            this.tytuł.Text = "Tytuł";
            // 
            // kategoria
            // 
            this.kategoria.FormattingEnabled = true;
            this.kategoria.Location = new System.Drawing.Point(33, 140);
            this.kategoria.Name = "kategoria";
            this.kategoria.Size = new System.Drawing.Size(196, 21);
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
            this.typ.Location = new System.Drawing.Point(33, 113);
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(196, 21);
            this.typ.TabIndex = 5;
            this.typ.Text = "Typ";
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(71, 283);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(112, 33);
            this.dodaj.TabIndex = 6;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // opis
            // 
            this.opis.Location = new System.Drawing.Point(33, 181);
            this.opis.Multiline = true;
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(196, 74);
            this.opis.TabIndex = 7;
            this.opis.Text = "Opis";
            // 
            // kategorie
            // 
            this.kategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.kategorie.Location = new System.Drawing.Point(542, 59);
            this.kategorie.Name = "kategorie";
            this.kategorie.Size = new System.Drawing.Size(193, 30);
            this.kategorie.TabIndex = 8;
            this.kategorie.Text = "Edytuj kategorie";
            this.kategorie.UseVisualStyleBackColor = true;
            this.kategorie.Click += new System.EventHandler(this.kategorie_Click);
            // 
            // Operacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kategorie);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.typ);
            this.Controls.Add(this.kategoria);
            this.Controls.Add(this.tytuł);
            this.Controls.Add(this.back);
            this.Name = "Operacja";
            this.Text = "Operacja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox tytuł;
        private System.Windows.Forms.ComboBox kategoria;
        private System.Windows.Forms.ComboBox typ;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.TextBox opis;
        private System.Windows.Forms.Button kategorie;
    }
}