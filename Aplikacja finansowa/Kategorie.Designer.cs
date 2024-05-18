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
            this.label2 = new System.Windows.Forms.Label();
            this.kategoriePrzychodów = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kategorieWydatków = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dodaj_kategorie_wydatku = new System.Windows.Forms.TextBox();
            this.dodaj_wyd = new System.Windows.Forms.Button();
            this.usun_wyd = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(351, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kategorie przychodów";
            // 
            // kategoriePrzychodów
            // 
            this.kategoriePrzychodów.FormattingEnabled = true;
            this.kategoriePrzychodów.Location = new System.Drawing.Point(354, 98);
            this.kategoriePrzychodów.Name = "kategoriePrzychodów";
            this.kategoriePrzychodów.Size = new System.Drawing.Size(246, 95);
            this.kategoriePrzychodów.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kategorie wydatków";
            // 
            // kategorieWydatków
            // 
            this.kategorieWydatków.FormattingEnabled = true;
            this.kategorieWydatków.Location = new System.Drawing.Point(26, 98);
            this.kategorieWydatków.Name = "kategorieWydatków";
            this.kategorieWydatków.Size = new System.Drawing.Size(246, 95);
            this.kategorieWydatków.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(23, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dodaj / usuń kategorię wydatków:";
            // 
            // dodaj_kategorie_wydatku
            // 
            this.dodaj_kategorie_wydatku.Location = new System.Drawing.Point(26, 246);
            this.dodaj_kategorie_wydatku.Name = "dodaj_kategorie_wydatku";
            this.dodaj_kategorie_wydatku.Size = new System.Drawing.Size(179, 20);
            this.dodaj_kategorie_wydatku.TabIndex = 17;
            // 
            // dodaj_wyd
            // 
            this.dodaj_wyd.Location = new System.Drawing.Point(26, 272);
            this.dodaj_wyd.Name = "dodaj_wyd";
            this.dodaj_wyd.Size = new System.Drawing.Size(75, 23);
            this.dodaj_wyd.TabIndex = 18;
            this.dodaj_wyd.Text = "Dodaj";
            this.dodaj_wyd.UseVisualStyleBackColor = true;
            this.dodaj_wyd.Click += new System.EventHandler(this.dodaj_wyd_Click);
            // 
            // usun_wyd
            // 
            this.usun_wyd.Location = new System.Drawing.Point(107, 272);
            this.usun_wyd.Name = "usun_wyd";
            this.usun_wyd.Size = new System.Drawing.Size(75, 23);
            this.usun_wyd.TabIndex = 19;
            this.usun_wyd.Text = "Usuń";
            this.usun_wyd.UseVisualStyleBackColor = true;
            this.usun_wyd.Click += new System.EventHandler(this.usun_wyd_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(81, 30);
            this.back.TabIndex = 20;
            this.back.Text = "Powrót";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Kategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.usun_wyd);
            this.Controls.Add(this.dodaj_wyd);
            this.Controls.Add(this.dodaj_kategorie_wydatku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kategoriePrzychodów);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kategorieWydatków);
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
    }
}