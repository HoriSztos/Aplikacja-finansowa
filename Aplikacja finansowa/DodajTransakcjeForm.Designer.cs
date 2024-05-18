namespace AplikacjaFinansowa
{
    partial class DodajTransakcjeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTyp = new System.Windows.Forms.Label();
            this.comboBoxTyp = new System.Windows.Forms.ComboBox();
            this.labelKwota = new System.Windows.Forms.Label();
            this.textBoxKwota = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTyp
            // 
            this.labelTyp.AutoSize = true;
            this.labelTyp.Location = new System.Drawing.Point(25, 25);
            this.labelTyp.Name = "labelTyp";
            this.labelTyp.Size = new System.Drawing.Size(28, 13);
            this.labelTyp.TabIndex = 0;
            this.labelTyp.Text = "Typ:";
            // 
            // comboBoxTyp
            // 
            this.comboBoxTyp.FormattingEnabled = true;
            this.comboBoxTyp.Items.AddRange(new object[] {
            "Koszt",
            "Przychód"});
            this.comboBoxTyp.Location = new System.Drawing.Point(80, 22);
            this.comboBoxTyp.Name = "comboBoxTyp";
            this.comboBoxTyp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTyp.TabIndex = 1;
            // 
            // labelKwota
            // 
            this.labelKwota.AutoSize = true;
            this.labelKwota.Location = new System.Drawing.Point(25, 60);
            this.labelKwota.Name = "labelKwota";
            this.labelKwota.Size = new System.Drawing.Size(41, 13);
            this.labelKwota.TabIndex = 2;
            this.labelKwota.Text = "Kwota:";
            // 
            // textBoxKwota
            // 
            this.textBoxKwota.Location = new System.Drawing.Point(80, 57);
            this.textBoxKwota.Name = "textBoxKwota";
            this.textBoxKwota.Size = new System.Drawing.Size(100, 20);
            this.textBoxKwota.TabIndex = 3;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(25, 95);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 4;
            this.labelData.Text = "Data:";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(80, 92);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerData.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(80, 135);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // DodajTransakcjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 182);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textBoxKwota);
            this.Controls.Add(this.labelKwota);
            this.Controls.Add(this.comboBoxTyp);
            this.Controls.Add(this.labelTyp);
            this.Name = "DodajTransakcjeForm";
            this.Text = "Dodaj nową transakcję";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTyp;
        private System.Windows.Forms.ComboBox comboBoxTyp;
        private System.Windows.Forms.Label labelKwota;
        private System.Windows.Forms.TextBox textBoxKwota;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Button btnDodaj;
    }
}
