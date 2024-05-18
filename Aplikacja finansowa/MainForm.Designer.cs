namespace AplikacjaFinansowa
{
    partial class MainForm
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
            this.listViewTransakcje = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTyp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKwota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajTransakcje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewTransakcje
            // 
            this.listViewTransakcje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderTyp,
            this.columnHeaderKwota,
            this.columnHeaderData});
            this.listViewTransakcje.FullRowSelect = true;
            this.listViewTransakcje.HideSelection = false;
            this.listViewTransakcje.Location = new System.Drawing.Point(12, 12);
            this.listViewTransakcje.Name = "listViewTransakcje";
            this.listViewTransakcje.Size = new System.Drawing.Size(460, 200);
            this.listViewTransakcje.TabIndex = 0;
            this.listViewTransakcje.UseCompatibleStateImageBehavior = false;
            this.listViewTransakcje.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 40;
            // 
            // columnHeaderTyp
            // 
            this.columnHeaderTyp.Text = "Typ";
            this.columnHeaderTyp.Width = 100;
            // 
            // columnHeaderKwota
            // 
            this.columnHeaderKwota.Text = "Kwota";
            this.columnHeaderKwota.Width = 100;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            this.columnHeaderData.Width = 150;
            // 
            // btnDodajTransakcje
            // 
            this.btnDodajTransakcje.Location = new System.Drawing.Point(12, 218);
            this.btnDodajTransakcje.Name = "btnDodajTransakcje";
            this.btnDodajTransakcje.Size = new System.Drawing.Size(120, 23);
            this.btnDodajTransakcje.TabIndex = 1;
            this.btnDodajTransakcje.Text = "Dodaj transakcję";
            this.btnDodajTransakcje.UseVisualStyleBackColor = true;
            this.btnDodajTransakcje.Click += new System.EventHandler(this.btnDodajTransakcje_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnDodajTransakcje);
            this.Controls.Add(this.listViewTransakcje);
            this.Name = "MainForm";
            this.Text = "Moja Aplikacja Finansowa";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListView listViewTransakcje;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderTyp;
        private System.Windows.Forms.ColumnHeader columnHeaderKwota;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.Button btnDodajTransakcje;
    }
}
