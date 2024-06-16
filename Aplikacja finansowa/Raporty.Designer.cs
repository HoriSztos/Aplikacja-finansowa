namespace Aplikacja_finansowa
{
    partial class Raporty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporty));
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.generuj = new System.Windows.Forms.Button();
            this.tydzien = new System.Windows.Forms.Button();
            this.miesiac = new System.Windows.Forms.Button();
            this.rok = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.data_poczatek = new System.Windows.Forms.Label();
            this.data_koncowa = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(34, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz zakres dat:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthCalendar1.Location = new System.Drawing.Point(343, 161);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(24, 21, 24, 21);
            this.monthCalendar1.MaxSelectionCount = 9999999;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 1;
            // 
            // generuj
            // 
            this.generuj.AutoSize = true;
            this.generuj.BackColor = System.Drawing.Color.SteelBlue;
            this.generuj.FlatAppearance.BorderSize = 0;
            this.generuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generuj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generuj.ForeColor = System.Drawing.Color.White;
            this.generuj.Location = new System.Drawing.Point(645, 300);
            this.generuj.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(247, 58);
            this.generuj.TabIndex = 2;
            this.generuj.Text = "Generuj raport";
            this.generuj.UseVisualStyleBackColor = false;
            this.generuj.Click += new System.EventHandler(this.generuj_Click);
            // 
            // tydzien
            // 
            this.tydzien.AutoSize = true;
            this.tydzien.BackColor = System.Drawing.Color.SteelBlue;
            this.tydzien.FlatAppearance.BorderSize = 0;
            this.tydzien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tydzien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tydzien.ForeColor = System.Drawing.Color.White;
            this.tydzien.Location = new System.Drawing.Point(56, 161);
            this.tydzien.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tydzien.Name = "tydzien";
            this.tydzien.Size = new System.Drawing.Size(223, 52);
            this.tydzien.TabIndex = 3;
            this.tydzien.Text = "Ostatni tydzień";
            this.tydzien.UseVisualStyleBackColor = false;
            this.tydzien.Click += new System.EventHandler(this.tydzien_Click);
            // 
            // miesiac
            // 
            this.miesiac.AutoSize = true;
            this.miesiac.BackColor = System.Drawing.Color.SteelBlue;
            this.miesiac.FlatAppearance.BorderSize = 0;
            this.miesiac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miesiac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miesiac.ForeColor = System.Drawing.Color.White;
            this.miesiac.Location = new System.Drawing.Point(56, 244);
            this.miesiac.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.miesiac.Name = "miesiac";
            this.miesiac.Size = new System.Drawing.Size(223, 52);
            this.miesiac.TabIndex = 4;
            this.miesiac.Text = "Ostatni miesiąc";
            this.miesiac.UseVisualStyleBackColor = false;
            this.miesiac.Click += new System.EventHandler(this.miesiac_Click);
            // 
            // rok
            // 
            this.rok.AutoSize = true;
            this.rok.BackColor = System.Drawing.Color.SteelBlue;
            this.rok.FlatAppearance.BorderSize = 0;
            this.rok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rok.ForeColor = System.Drawing.Color.White;
            this.rok.Location = new System.Drawing.Point(56, 328);
            this.rok.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rok.Name = "rok";
            this.rok.Size = new System.Drawing.Size(223, 64);
            this.rok.TabIndex = 5;
            this.rok.Text = "Od początku roku";
            this.rok.UseVisualStyleBackColor = false;
            this.rok.Click += new System.EventHandler(this.rok_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.SteelBlue;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(37, 16);
            this.back.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(143, 52);
            this.back.TabIndex = 6;
            this.back.Text = "Powrót";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // data_poczatek
            // 
            this.data_poczatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.data_poczatek.Location = new System.Drawing.Point(642, 109);
            this.data_poczatek.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.data_poczatek.Name = "data_poczatek";
            this.data_poczatek.Size = new System.Drawing.Size(435, 39);
            this.data_poczatek.TabIndex = 7;
            this.data_poczatek.Text = "Data początkowa:  ";
            // 
            // data_koncowa
            // 
            this.data_koncowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.data_koncowa.Location = new System.Drawing.Point(642, 171);
            this.data_koncowa.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.data_koncowa.Name = "data_koncowa";
            this.data_koncowa.Size = new System.Drawing.Size(390, 39);
            this.data_koncowa.TabIndex = 8;
            this.data_koncowa.Text = "Data końcowa: ";
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.BackColor = System.Drawing.Color.SteelBlue;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(644, 217);
            this.clear.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(223, 41);
            this.clear.TabIndex = 9;
            this.clear.Text = "Wyczyść zaznaczenie";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Raporty
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(932, 507);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.data_koncowa);
            this.Controls.Add(this.data_poczatek);
            this.Controls.Add(this.back);
            this.Controls.Add(this.rok);
            this.Controls.Add(this.miesiac);
            this.Controls.Add(this.tydzien);
            this.Controls.Add(this.generuj);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Raporty";
            this.Text = "Raporty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button generuj;
        private System.Windows.Forms.Button tydzien;
        private System.Windows.Forms.Button miesiac;
        private System.Windows.Forms.Button rok;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label data_poczatek;
        private System.Windows.Forms.Label data_koncowa;
        private System.Windows.Forms.Button clear;
    }
}