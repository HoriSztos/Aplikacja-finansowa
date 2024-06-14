namespace Aplikacja_finansowa
{
    partial class MainMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raporty = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.zarzadzaj = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raporty);
            this.groupBox1.Controls.Add(this.dodaj);
            this.groupBox1.Controls.Add(this.zarzadzaj);
            this.groupBox1.Location = new System.Drawing.Point(272, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(2360, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // raporty
            // 
            this.raporty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.raporty.Location = new System.Drawing.Point(1560, 38);
            this.raporty.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.raporty.Name = "raporty";
            this.raporty.Size = new System.Drawing.Size(760, 186);
            this.raporty.TabIndex = 2;
            this.raporty.Text = "Generowanie raportów";
            this.raporty.UseVisualStyleBackColor = true;
            this.raporty.Click += new System.EventHandler(this.raporty_Click);
            // 
            // dodaj
            // 
            this.dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.dodaj.Location = new System.Drawing.Point(784, 38);
            this.dodaj.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(760, 186);
            this.dodaj.TabIndex = 1;
            this.dodaj.Text = "Dodaj operację";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // zarzadzaj
            // 
            this.zarzadzaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.zarzadzaj.Location = new System.Drawing.Point(8, 38);
            this.zarzadzaj.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.zarzadzaj.Name = "zarzadzaj";
            this.zarzadzaj.Size = new System.Drawing.Size(760, 186);
            this.zarzadzaj.TabIndex = 0;
            this.zarzadzaj.Text = "Zarządzanie finansami";
            this.zarzadzaj.UseVisualStyleBackColor = true;
            this.zarzadzaj.Click += new System.EventHandler(this.zarzadzaj_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(67, 668);
            this.listBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(567, 717);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(67, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 96);
            this.label1.TabIndex = 5;
            this.label1.Text = "Witaj!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(53, 601);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 59);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ostatnie operacje";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2973, 1483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button raporty;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button zarzadzaj;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}