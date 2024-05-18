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
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz zakres dat:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(155, 60);
            this.monthCalendar1.MaxSelectionCount = 9999999;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 1;
            // 
            // generuj
            // 
            this.generuj.Location = new System.Drawing.Point(456, 186);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(75, 36);
            this.generuj.TabIndex = 2;
            this.generuj.Text = "Generuj raport";
            this.generuj.UseVisualStyleBackColor = true;
            // 
            // tydzien
            // 
            this.tydzien.Location = new System.Drawing.Point(30, 90);
            this.tydzien.Name = "tydzien";
            this.tydzien.Size = new System.Drawing.Size(91, 29);
            this.tydzien.TabIndex = 3;
            this.tydzien.Text = "Ostatni tydzień";
            this.tydzien.UseVisualStyleBackColor = true;
            this.tydzien.Click += new System.EventHandler(this.tydzien_Click);
            // 
            // miesiac
            // 
            this.miesiac.Location = new System.Drawing.Point(30, 125);
            this.miesiac.Name = "miesiac";
            this.miesiac.Size = new System.Drawing.Size(91, 29);
            this.miesiac.TabIndex = 4;
            this.miesiac.Text = "Ostatni miesiąc";
            this.miesiac.UseVisualStyleBackColor = true;
            this.miesiac.Click += new System.EventHandler(this.miesiac_Click);
            // 
            // rok
            // 
            this.rok.Location = new System.Drawing.Point(30, 160);
            this.rok.Name = "rok";
            this.rok.Size = new System.Drawing.Size(91, 34);
            this.rok.TabIndex = 5;
            this.rok.Text = "Od początku roku";
            this.rok.UseVisualStyleBackColor = true;
            this.rok.Click += new System.EventHandler(this.rok_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(81, 30);
            this.back.TabIndex = 6;
            this.back.Text = "Powrót";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // data_poczatek
            // 
            this.data_poczatek.AutoSize = true;
            this.data_poczatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.data_poczatek.Location = new System.Drawing.Point(436, 76);
            this.data_poczatek.Name = "data_poczatek";
            this.data_poczatek.Size = new System.Drawing.Size(120, 17);
            this.data_poczatek.TabIndex = 7;
            this.data_poczatek.Text = "Data początkowa:";
            // 
            // data_koncowa
            // 
            this.data_koncowa.AutoSize = true;
            this.data_koncowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.data_koncowa.Location = new System.Drawing.Point(436, 102);
            this.data_koncowa.Name = "data_koncowa";
            this.data_koncowa.Size = new System.Drawing.Size(101, 17);
            this.data_koncowa.TabIndex = 8;
            this.data_koncowa.Text = "Data końcowa:";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(437, 123);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(129, 20);
            this.clear.TabIndex = 9;
            this.clear.Text = "Wyczyść zaznaczenie";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Raporty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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