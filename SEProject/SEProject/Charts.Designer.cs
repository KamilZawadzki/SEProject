namespace SEProject
{
    partial class Charts
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
            this.textBox_wyszukaj = new System.Windows.Forms.TextBox();
            this.button_wyczysc_zazn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_szablony = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_generuj_wykres = new System.Windows.Forms.Button();
            this.listBox_atrybuty = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_model = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_wyszukaj
            // 
            this.textBox_wyszukaj.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox_wyszukaj.Location = new System.Drawing.Point(4, 274);
            this.textBox_wyszukaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_wyszukaj.Name = "textBox_wyszukaj";
            this.textBox_wyszukaj.Size = new System.Drawing.Size(200, 20);
            this.textBox_wyszukaj.TabIndex = 2;
            this.textBox_wyszukaj.Text = "Wyszukaj...";
            // 
            // button_wyczysc_zazn
            // 
            this.button_wyczysc_zazn.Location = new System.Drawing.Point(4, 298);
            this.button_wyczysc_zazn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_wyczysc_zazn.Name = "button_wyczysc_zazn";
            this.button_wyczysc_zazn.Size = new System.Drawing.Size(200, 26);
            this.button_wyczysc_zazn.TabIndex = 3;
            this.button_wyczysc_zazn.Text = "Wyczyść zaznaczenie";
            this.button_wyczysc_zazn.UseVisualStyleBackColor = true;
            this.button_wyczysc_zazn.Click += new System.EventHandler(this.button_wyczysc_zazn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_szablony);
            this.groupBox1.Location = new System.Drawing.Point(16, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(237, 391);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dostępne szablony wykresów";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBox_szablony
            // 
            this.listBox_szablony.FormattingEnabled = true;
            this.listBox_szablony.HorizontalScrollbar = true;
            this.listBox_szablony.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox_szablony.Items.AddRange(new object[] {
            "Ilość sprzedanych telefonów z podziałem na ich marki",
            "Ilość sprzedanych laptopów z podziałem na ich marki",
            "Porównanie 2 wybranych telefonów pod względem wybranego parametru",
            "Porównanie 2 wybranych laptopów pod względem wybranego parametru",
            "Ilość laptopów zalegających w magazynie wybranego jednego producenta",
            "Ilość laptopów zalegających w magazynie wybranego jednego producenta"});
            this.listBox_szablony.Location = new System.Drawing.Point(4, 17);
            this.listBox_szablony.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_szablony.Name = "listBox_szablony";
            this.listBox_szablony.ScrollAlwaysVisible = true;
            this.listBox_szablony.Size = new System.Drawing.Size(229, 368);
            this.listBox_szablony.TabIndex = 0;
            this.listBox_szablony.SelectedIndexChanged += new System.EventHandler(this.listBox_szablony_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_model);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listBox_atrybuty);
            this.groupBox2.Controls.Add(this.button_wyczysc_zazn);
            this.groupBox2.Controls.Add(this.textBox_wyszukaj);
            this.groupBox2.Location = new System.Drawing.Point(258, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(208, 335);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atrybuty";
            // 
            // button_generuj_wykres
            // 
            this.button_generuj_wykres.Location = new System.Drawing.Point(262, 375);
            this.button_generuj_wykres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_generuj_wykres.Name = "button_generuj_wykres";
            this.button_generuj_wykres.Size = new System.Drawing.Size(200, 26);
            this.button_generuj_wykres.TabIndex = 7;
            this.button_generuj_wykres.Text = "Wygeneruj wykres";
            this.button_generuj_wykres.UseVisualStyleBackColor = true;
            this.button_generuj_wykres.Click += new System.EventHandler(this.button_generuj_wykres_Click);
            // 
            // listBox_atrybuty
            // 
            this.listBox_atrybuty.FormattingEnabled = true;
            this.listBox_atrybuty.HorizontalScrollbar = true;
            this.listBox_atrybuty.Location = new System.Drawing.Point(15, 18);
            this.listBox_atrybuty.Name = "listBox_atrybuty";
            this.listBox_atrybuty.ScrollAlwaysVisible = true;
            this.listBox_atrybuty.Size = new System.Drawing.Size(187, 108);
            this.listBox_atrybuty.TabIndex = 4;
            this.listBox_atrybuty.SelectedIndexChanged += new System.EventHandler(this.listBox_atrybuty_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Model";
            // 
            // listBox_model
            // 
            this.listBox_model.FormattingEnabled = true;
            this.listBox_model.HorizontalScrollbar = true;
            this.listBox_model.Location = new System.Drawing.Point(15, 159);
            this.listBox_model.Name = "listBox_model";
            this.listBox_model.ScrollAlwaysVisible = true;
            this.listBox_model.Size = new System.Drawing.Size(187, 95);
            this.listBox_model.TabIndex = 6;
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 426);
            this.Controls.Add(this.button_generuj_wykres);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Charts";
            this.Text = "Wykresy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_wyszukaj;
        private System.Windows.Forms.Button button_wyczysc_zazn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_generuj_wykres;
        private System.Windows.Forms.ListBox listBox_szablony;
        private System.Windows.Forms.ListBox listBox_atrybuty;
        private System.Windows.Forms.ListBox listBox_model;
        private System.Windows.Forms.Label label1;
    }
}

