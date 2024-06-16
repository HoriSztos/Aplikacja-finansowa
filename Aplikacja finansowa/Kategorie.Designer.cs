using System.Drawing;
using System.Windows.Forms;

namespace Aplikacja_finansowa
{
    partial class Kategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kategorie));
            this.label2 = new System.Windows.Forms.Label();
            this.kategoriePrzychodów = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kategorieWydatków = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dodaj_kategorie_wydatku = new System.Windows.Forms.TextBox();
            this.dodaj_wyd = new System.Windows.Forms.Button();
            this.usun_wyd = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.usun_przych = new System.Windows.Forms.Button();
            this.dod_przych = new System.Windows.Forms.Button();
            this.dodaj_kategorie_przychodu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(935, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kategorie przychodów";
            // 
            // kategoriePrzychodów
            // 
            this.kategoriePrzychodów.FormattingEnabled = true;
            this.kategoriePrzychodów.ItemHeight = 31;
            this.kategoriePrzychodów.Location = new System.Drawing.Point(945, 235);
            this.kategoriePrzychodów.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.kategoriePrzychodów.Name = "kategoriePrzychodów";
            this.kategoriePrzychodów.Size = new System.Drawing.Size(649, 190);
            this.kategoriePrzychodów.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(60, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kategorie wydatków";
            // 
            // kategorieWydatków
            // 
            this.kategorieWydatków.FormattingEnabled = true;
            this.kategorieWydatków.ItemHeight = 31;
            this.kategorieWydatków.Location = new System.Drawing.Point(70, 235);
            this.kategorieWydatków.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.kategorieWydatków.Name = "kategorieWydatków";
            this.kategorieWydatków.Size = new System.Drawing.Size(649, 190);
            this.kategorieWydatków.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(60, 512);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(534, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dodaj / usuń kategorię wydatków:";
            // 
            // dodaj_kategorie_wydatku
            // 
            this.dodaj_kategorie_wydatku.Location = new System.Drawing.Point(70, 588);
            this.dodaj_kategorie_wydatku.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dodaj_kategorie_wydatku.Name = "dodaj_kategorie_wydatku";
            this.dodaj_kategorie_wydatku.Size = new System.Drawing.Size(472, 38);
            this.dodaj_kategorie_wydatku.TabIndex = 17;
            // 
            // dodaj_wyd
            // 
            this.dodaj_wyd.AutoSize = true;
            this.dodaj_wyd.BackColor = System.Drawing.Color.SteelBlue;
            this.dodaj_wyd.FlatAppearance.BorderSize = 0;
            this.dodaj_wyd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodaj_wyd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dodaj_wyd.ForeColor = System.Drawing.Color.White;
            this.dodaj_wyd.Location = new System.Drawing.Point(68, 682);
            this.dodaj_wyd.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dodaj_wyd.Name = "dodaj_wyd";
            this.dodaj_wyd.Size = new System.Drawing.Size(200, 78);
            this.dodaj_wyd.TabIndex = 18;
            this.dodaj_wyd.Text = "Dodaj";
            this.dodaj_wyd.UseVisualStyleBackColor = false;
            this.dodaj_wyd.Click += new System.EventHandler(this.dodaj_wyd_Click);
            // 
            // usun_wyd
            // 
            this.usun_wyd.AutoSize = true;
            this.usun_wyd.BackColor = System.Drawing.Color.SteelBlue;
            this.usun_wyd.FlatAppearance.BorderSize = 0;
            this.usun_wyd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usun_wyd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.usun_wyd.ForeColor = System.Drawing.Color.White;
            this.usun_wyd.Location = new System.Drawing.Point(282, 682);
            this.usun_wyd.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.usun_wyd.Name = "usun_wyd";
            this.usun_wyd.Size = new System.Drawing.Size(200, 78);
            this.usun_wyd.TabIndex = 19;
            this.usun_wyd.Text = "Usuń";
            this.usun_wyd.UseVisualStyleBackColor = false;
            this.usun_wyd.Click += new System.EventHandler(this.usun_wyd_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.SteelBlue;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(32, 30);
            this.back.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(215, 72);
            this.back.TabIndex = 20;
            this.back.Text = "Powrót";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // usun_przych
            // 
            this.usun_przych.AutoSize = true;
            this.usun_przych.BackColor = System.Drawing.Color.SteelBlue;
            this.usun_przych.FlatAppearance.BorderSize = 0;
            this.usun_przych.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usun_przych.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.usun_przych.ForeColor = System.Drawing.Color.White;
            this.usun_przych.Location = new System.Drawing.Point(1158, 682);
            this.usun_przych.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.usun_przych.Name = "usun_przych";
            this.usun_przych.Size = new System.Drawing.Size(200, 78);
            this.usun_przych.TabIndex = 24;
            this.usun_przych.Text = "Usuń";
            this.usun_przych.UseVisualStyleBackColor = false;
            this.usun_przych.Click += new System.EventHandler(this.usun_przych_Click);
            // 
            // dod_przych
            // 
            this.dod_przych.AutoSize = true;
            this.dod_przych.BackColor = System.Drawing.Color.SteelBlue;
            this.dod_przych.FlatAppearance.BorderSize = 0;
            this.dod_przych.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dod_przych.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dod_przych.ForeColor = System.Drawing.Color.White;
            this.dod_przych.Location = new System.Drawing.Point(942, 682);
            this.dod_przych.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dod_przych.Name = "dod_przych";
            this.dod_przych.Size = new System.Drawing.Size(200, 78);
            this.dod_przych.TabIndex = 23;
            this.dod_przych.Text = "Dodaj";
            this.dod_przych.UseVisualStyleBackColor = false;
            this.dod_przych.Click += new System.EventHandler(this.dod_przych_Click);
            // 
            // dodaj_kategorie_przychodu
            // 
            this.dodaj_kategorie_przychodu.Location = new System.Drawing.Point(942, 588);
            this.dodaj_kategorie_przychodu.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dodaj_kategorie_przychodu.Name = "dodaj_kategorie_przychodu";
            this.dodaj_kategorie_przychodu.Size = new System.Drawing.Size(472, 38);
            this.dodaj_kategorie_przychodu.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(938, 512);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(567, 39);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dodaj / usuń kategorię przychodów:";
            // 
            // Kategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1842, 950);
            this.Controls.Add(this.usun_przych);
            this.Controls.Add(this.dod_przych);
            this.Controls.Add(this.dodaj_kategorie_przychodu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.back);
            this.Controls.Add(this.usun_wyd);
            this.Controls.Add(this.dodaj_wyd);
            this.Controls.Add(this.dodaj_kategorie_wydatku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kategoriePrzychodów);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kategorieWydatków);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Kategorie";
            this.Text = "Kategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox kategoriePrzychodów;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox kategorieWydatków;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dodaj_kategorie_wydatku;
        private System.Windows.Forms.Button dodaj_wyd;
        private System.Windows.Forms.Button usun_wyd;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button usun_przych;
        private System.Windows.Forms.Button dod_przych;
        private System.Windows.Forms.TextBox dodaj_kategorie_przychodu;
        private System.Windows.Forms.Label label4;
    }
}