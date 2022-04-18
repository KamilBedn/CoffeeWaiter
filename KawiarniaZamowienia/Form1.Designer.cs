namespace KawiarniaZamowienia
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.Ciasta = new System.Windows.Forms.GroupBox();
            this.CiastoZJagodami = new System.Windows.Forms.RadioButton();
            this.CiastoZJablkami = new System.Windows.Forms.RadioButton();
            this.CiastoZMalinami = new System.Windows.Forms.RadioButton();
            this.Sernik = new System.Windows.Forms.RadioButton();
            this.WagaCiast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Napoje = new System.Windows.Forms.GroupBox();
            this.ZamówienieKawy = new System.Windows.Forms.Button();
            this.KawaBiala = new System.Windows.Forms.RadioButton();
            this.KawaCzarna = new System.Windows.Forms.RadioButton();
            this.Zaplac = new System.Windows.Forms.Button();
            this.Zaplata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Podsumowanie = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Ciasta.SuspendLayout();
            this.Napoje.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 28);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.oProgramieToolStripMenuItem.Text = "O Programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.CausesValidation = false;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Ciasta);
            this.splitContainer1.Panel1.Controls.Add(this.Napoje);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Zaplac);
            this.splitContainer1.Panel2.Controls.Add(this.Zaplata);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.Podsumowanie);
            this.splitContainer1.Size = new System.Drawing.Size(471, 654);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zamowienie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Ciasta
            // 
            this.Ciasta.Controls.Add(this.CiastoZJagodami);
            this.Ciasta.Controls.Add(this.CiastoZJablkami);
            this.Ciasta.Controls.Add(this.CiastoZMalinami);
            this.Ciasta.Controls.Add(this.Sernik);
            this.Ciasta.Controls.Add(this.WagaCiast);
            this.Ciasta.Controls.Add(this.label2);
            this.Ciasta.Controls.Add(this.button1);
            this.Ciasta.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ciasta.ForeColor = System.Drawing.Color.White;
            this.Ciasta.Location = new System.Drawing.Point(13, 211);
            this.Ciasta.Name = "Ciasta";
            this.Ciasta.Size = new System.Drawing.Size(200, 257);
            this.Ciasta.TabIndex = 1;
            this.Ciasta.TabStop = false;
            this.Ciasta.Text = "Ciasta";
            // 
            // CiastoZJagodami
            // 
            this.CiastoZJagodami.AutoSize = true;
            this.CiastoZJagodami.Location = new System.Drawing.Point(6, 154);
            this.CiastoZJagodami.Name = "CiastoZJagodami";
            this.CiastoZJagodami.Size = new System.Drawing.Size(137, 21);
            this.CiastoZJagodami.TabIndex = 10;
            this.CiastoZJagodami.TabStop = true;
            this.CiastoZJagodami.Text = "Ciasto z jagodami";
            this.CiastoZJagodami.UseVisualStyleBackColor = true;
            // 
            // CiastoZJablkami
            // 
            this.CiastoZJablkami.AutoSize = true;
            this.CiastoZJablkami.Location = new System.Drawing.Point(7, 116);
            this.CiastoZJablkami.Name = "CiastoZJablkami";
            this.CiastoZJablkami.Size = new System.Drawing.Size(136, 21);
            this.CiastoZJablkami.TabIndex = 9;
            this.CiastoZJablkami.TabStop = true;
            this.CiastoZJablkami.Text = "Ciasto z jabłkami";
            this.CiastoZJablkami.UseVisualStyleBackColor = true;
            // 
            // CiastoZMalinami
            // 
            this.CiastoZMalinami.AutoSize = true;
            this.CiastoZMalinami.Location = new System.Drawing.Point(6, 78);
            this.CiastoZMalinami.Name = "CiastoZMalinami";
            this.CiastoZMalinami.Size = new System.Drawing.Size(140, 21);
            this.CiastoZMalinami.TabIndex = 8;
            this.CiastoZMalinami.TabStop = true;
            this.CiastoZMalinami.Text = "Ciasto z malinami";
            this.CiastoZMalinami.UseVisualStyleBackColor = true;
            // 
            // Sernik
            // 
            this.Sernik.AutoSize = true;
            this.Sernik.Location = new System.Drawing.Point(7, 41);
            this.Sernik.Name = "Sernik";
            this.Sernik.Size = new System.Drawing.Size(71, 21);
            this.Sernik.TabIndex = 7;
            this.Sernik.TabStop = true;
            this.Sernik.Text = "Sernik";
            this.Sernik.UseVisualStyleBackColor = true;
            // 
            // WagaCiast
            // 
            this.WagaCiast.Location = new System.Drawing.Point(67, 196);
            this.WagaCiast.Name = "WagaCiast";
            this.WagaCiast.Size = new System.Drawing.Size(100, 22);
            this.WagaCiast.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Waga";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::KawiarniaZamowienia.Properties.Resources.TłoDoZamowien;
            this.button1.Location = new System.Drawing.Point(119, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Napoje
            // 
            this.Napoje.Controls.Add(this.ZamówienieKawy);
            this.Napoje.Controls.Add(this.KawaBiala);
            this.Napoje.Controls.Add(this.KawaCzarna);
            this.Napoje.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Napoje.ForeColor = System.Drawing.Color.White;
            this.Napoje.Location = new System.Drawing.Point(12, 63);
            this.Napoje.Name = "Napoje";
            this.Napoje.Size = new System.Drawing.Size(200, 118);
            this.Napoje.TabIndex = 0;
            this.Napoje.TabStop = false;
            this.Napoje.Text = "Napoje";
            // 
            // ZamówienieKawy
            // 
            this.ZamówienieKawy.BackColor = System.Drawing.Color.Transparent;
            this.ZamówienieKawy.BackgroundImage = global::KawiarniaZamowienia.Properties.Resources.TłoDoZamowien;
            this.ZamówienieKawy.Location = new System.Drawing.Point(119, 88);
            this.ZamówienieKawy.Name = "ZamówienieKawy";
            this.ZamówienieKawy.Size = new System.Drawing.Size(75, 24);
            this.ZamówienieKawy.TabIndex = 2;
            this.ZamówienieKawy.Text = "Dodaj";
            this.ZamówienieKawy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ZamówienieKawy.UseVisualStyleBackColor = false;
            this.ZamówienieKawy.Click += new System.EventHandler(this.ZamówienieKawy_Click);
            // 
            // KawaBiala
            // 
            this.KawaBiala.AutoSize = true;
            this.KawaBiala.Location = new System.Drawing.Point(7, 61);
            this.KawaBiala.Name = "KawaBiala";
            this.KawaBiala.Size = new System.Drawing.Size(97, 21);
            this.KawaBiala.TabIndex = 1;
            this.KawaBiala.Text = "Kawa Biała";
            this.KawaBiala.UseVisualStyleBackColor = true;
            // 
            // KawaCzarna
            // 
            this.KawaCzarna.AutoSize = true;
            this.KawaCzarna.Checked = true;
            this.KawaCzarna.Location = new System.Drawing.Point(7, 33);
            this.KawaCzarna.Name = "KawaCzarna";
            this.KawaCzarna.Size = new System.Drawing.Size(106, 21);
            this.KawaCzarna.TabIndex = 0;
            this.KawaCzarna.TabStop = true;
            this.KawaCzarna.Text = "Kawa czarna";
            this.KawaCzarna.UseVisualStyleBackColor = true;
            // 
            // Zaplac
            // 
            this.Zaplac.BackgroundImage = global::KawiarniaZamowienia.Properties.Resources.TłoDoZamowien;
            this.Zaplac.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zaplac.ForeColor = System.Drawing.Color.White;
            this.Zaplac.Location = new System.Drawing.Point(142, 486);
            this.Zaplac.Name = "Zaplac";
            this.Zaplac.Size = new System.Drawing.Size(75, 23);
            this.Zaplac.TabIndex = 4;
            this.Zaplac.Text = "Zapłać";
            this.Zaplac.UseVisualStyleBackColor = true;
            this.Zaplac.Click += new System.EventHandler(this.Zaplac_Click);
            // 
            // Zaplata
            // 
            this.Zaplata.Location = new System.Drawing.Point(118, 446);
            this.Zaplata.Name = "Zaplata";
            this.Zaplata.ReadOnly = true;
            this.Zaplata.Size = new System.Drawing.Size(100, 22);
            this.Zaplata.TabIndex = 3;
            this.Zaplata.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Zaplata.TextChanged += new System.EventHandler(this.Zaplata_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Do zapłaty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Podsumowanie";
            // 
            // Podsumowanie
            // 
            this.Podsumowanie.BackColor = System.Drawing.SystemColors.Window;
            this.Podsumowanie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Podsumowanie.ContextMenuStrip = this.contextMenuStrip1;
            this.Podsumowanie.Location = new System.Drawing.Point(3, 196);
            this.Podsumowanie.Name = "Podsumowanie";
            this.Podsumowanie.Size = new System.Drawing.Size(215, 233);
            this.Podsumowanie.TabIndex = 0;
            this.Podsumowanie.Text = "";
            this.Podsumowanie.TextChanged += new System.EventHandler(this.Podsumowanie_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KawiarniaZamowienia.Properties.Resources.TłoDoZamowien;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 654);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Ciasta.ResumeLayout(false);
            this.Ciasta.PerformLayout();
            this.Napoje.ResumeLayout(false);
            this.Napoje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Ciasta;
        private System.Windows.Forms.GroupBox Napoje;
        private System.Windows.Forms.Button ZamówienieKawy;
        private System.Windows.Forms.RadioButton KawaBiala;
        private System.Windows.Forms.RadioButton KawaCzarna;
        private System.Windows.Forms.TextBox WagaCiast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton CiastoZJagodami;
        private System.Windows.Forms.RadioButton CiastoZJablkami;
        private System.Windows.Forms.RadioButton CiastoZMalinami;
        private System.Windows.Forms.RadioButton Sernik;
        private System.Windows.Forms.RichTextBox Podsumowanie;
        private System.Windows.Forms.TextBox Zaplata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Zaplac;
    }
}

