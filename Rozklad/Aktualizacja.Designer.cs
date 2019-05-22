namespace Rozklad
{
    partial class Aktualizacja
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
            this.NoDownload = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.Button();
            this.Zamknij = new System.Windows.Forms.Button();
            this.Dostepne = new System.Windows.Forms.Label();
            this.labelPoznan = new System.Windows.Forms.Label();
            this.labelWroclaw = new System.Windows.Forms.Label();
            this.labelSzczecin = new System.Windows.Forms.Label();
            this.labelBydgoszcz = new System.Windows.Forms.Label();
            this.checkPoznan = new System.Windows.Forms.CheckBox();
            this.checkWroclaw = new System.Windows.Forms.CheckBox();
            this.checkSzczecin = new System.Windows.Forms.CheckBox();
            this.checkBydgoszcz = new System.Windows.Forms.CheckBox();
            this.pobranePoznan = new System.Windows.Forms.Label();
            this.pobraneWroclaw = new System.Windows.Forms.Label();
            this.pobraneSzczecin = new System.Windows.Forms.Label();
            this.pobraneBydgoszcz = new System.Windows.Forms.Label();
            this.aktPoznan = new System.Windows.Forms.Label();
            this.aktWroclaw = new System.Windows.Forms.Label();
            this.aktSzczecin = new System.Windows.Forms.Label();
            this.aktBydgoszcz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoDownload
            // 
            this.NoDownload.Location = new System.Drawing.Point(176, 217);
            this.NoDownload.Name = "NoDownload";
            this.NoDownload.Size = new System.Drawing.Size(89, 25);
            this.NoDownload.TabIndex = 0;
            this.NoDownload.Text = "Rozkład";
            this.NoDownload.UseVisualStyleBackColor = true;
            this.NoDownload.Click += new System.EventHandler(this.NoDownload_Click);
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(271, 217);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(90, 25);
            this.Download.TabIndex = 1;
            this.Download.Text = "Pobierz";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Zamknij
            // 
            this.Zamknij.Location = new System.Drawing.Point(12, 217);
            this.Zamknij.Name = "Zamknij";
            this.Zamknij.Size = new System.Drawing.Size(77, 25);
            this.Zamknij.TabIndex = 2;
            this.Zamknij.Text = "Wyjdź";
            this.Zamknij.UseVisualStyleBackColor = true;
            this.Zamknij.Click += new System.EventHandler(this.Zamknij_Click);
            // 
            // Dostepne
            // 
            this.Dostepne.AutoSize = true;
            this.Dostepne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dostepne.Location = new System.Drawing.Point(13, 13);
            this.Dostepne.Name = "Dostepne";
            this.Dostepne.Size = new System.Drawing.Size(182, 26);
            this.Dostepne.TabIndex = 3;
            this.Dostepne.Text = "Dostępne miasta:";
            // 
            // labelPoznan
            // 
            this.labelPoznan.AutoSize = true;
            this.labelPoznan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoznan.Location = new System.Drawing.Point(41, 66);
            this.labelPoznan.Name = "labelPoznan";
            this.labelPoznan.Size = new System.Drawing.Size(63, 20);
            this.labelPoznan.TabIndex = 4;
            this.labelPoznan.Text = "Poznan";
            // 
            // labelWroclaw
            // 
            this.labelWroclaw.AutoSize = true;
            this.labelWroclaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWroclaw.Location = new System.Drawing.Point(41, 100);
            this.labelWroclaw.Name = "labelWroclaw";
            this.labelWroclaw.Size = new System.Drawing.Size(69, 20);
            this.labelWroclaw.TabIndex = 5;
            this.labelWroclaw.Text = "Wroclaw";
            // 
            // labelSzczecin
            // 
            this.labelSzczecin.AutoSize = true;
            this.labelSzczecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzczecin.Location = new System.Drawing.Point(41, 137);
            this.labelSzczecin.Name = "labelSzczecin";
            this.labelSzczecin.Size = new System.Drawing.Size(73, 20);
            this.labelSzczecin.TabIndex = 6;
            this.labelSzczecin.Text = "Szczecin";
            // 
            // labelBydgoszcz
            // 
            this.labelBydgoszcz.AutoSize = true;
            this.labelBydgoszcz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBydgoszcz.Location = new System.Drawing.Point(41, 177);
            this.labelBydgoszcz.Name = "labelBydgoszcz";
            this.labelBydgoszcz.Size = new System.Drawing.Size(86, 20);
            this.labelBydgoszcz.TabIndex = 7;
            this.labelBydgoszcz.Text = "Bydgoszcz";
            // 
            // checkPoznan
            // 
            this.checkPoznan.AutoSize = true;
            this.checkPoznan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkPoznan.Location = new System.Drawing.Point(20, 70);
            this.checkPoznan.Name = "checkPoznan";
            this.checkPoznan.Size = new System.Drawing.Size(15, 14);
            this.checkPoznan.TabIndex = 8;
            this.checkPoznan.UseVisualStyleBackColor = true;
            this.checkPoznan.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkWroclaw
            // 
            this.checkWroclaw.AutoSize = true;
            this.checkWroclaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkWroclaw.Location = new System.Drawing.Point(20, 104);
            this.checkWroclaw.Name = "checkWroclaw";
            this.checkWroclaw.Size = new System.Drawing.Size(15, 14);
            this.checkWroclaw.TabIndex = 9;
            this.checkWroclaw.UseVisualStyleBackColor = true;
            // 
            // checkSzczecin
            // 
            this.checkSzczecin.AutoSize = true;
            this.checkSzczecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkSzczecin.Location = new System.Drawing.Point(20, 141);
            this.checkSzczecin.Name = "checkSzczecin";
            this.checkSzczecin.Size = new System.Drawing.Size(15, 14);
            this.checkSzczecin.TabIndex = 10;
            this.checkSzczecin.UseVisualStyleBackColor = true;
            // 
            // checkBydgoszcz
            // 
            this.checkBydgoszcz.AutoSize = true;
            this.checkBydgoszcz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBydgoszcz.Location = new System.Drawing.Point(20, 181);
            this.checkBydgoszcz.Name = "checkBydgoszcz";
            this.checkBydgoszcz.Size = new System.Drawing.Size(15, 14);
            this.checkBydgoszcz.TabIndex = 11;
            this.checkBydgoszcz.UseVisualStyleBackColor = true;
            // 
            // pobranePoznan
            // 
            this.pobranePoznan.AutoSize = true;
            this.pobranePoznan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pobranePoznan.ForeColor = System.Drawing.Color.Red;
            this.pobranePoznan.Location = new System.Drawing.Point(160, 71);
            this.pobranePoznan.Name = "pobranePoznan";
            this.pobranePoznan.Size = new System.Drawing.Size(76, 13);
            this.pobranePoznan.TabIndex = 12;
            this.pobranePoznan.Text = "Nie pobrane";
            // 
            // pobraneWroclaw
            // 
            this.pobraneWroclaw.AutoSize = true;
            this.pobraneWroclaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pobraneWroclaw.ForeColor = System.Drawing.Color.Red;
            this.pobraneWroclaw.Location = new System.Drawing.Point(160, 105);
            this.pobraneWroclaw.Name = "pobraneWroclaw";
            this.pobraneWroclaw.Size = new System.Drawing.Size(76, 13);
            this.pobraneWroclaw.TabIndex = 13;
            this.pobraneWroclaw.Text = "Nie pobrane";
            // 
            // pobraneSzczecin
            // 
            this.pobraneSzczecin.AutoSize = true;
            this.pobraneSzczecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pobraneSzczecin.ForeColor = System.Drawing.Color.Red;
            this.pobraneSzczecin.Location = new System.Drawing.Point(160, 142);
            this.pobraneSzczecin.Name = "pobraneSzczecin";
            this.pobraneSzczecin.Size = new System.Drawing.Size(76, 13);
            this.pobraneSzczecin.TabIndex = 14;
            this.pobraneSzczecin.Text = "Nie pobrane";
            // 
            // pobraneBydgoszcz
            // 
            this.pobraneBydgoszcz.AutoSize = true;
            this.pobraneBydgoszcz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pobraneBydgoszcz.ForeColor = System.Drawing.Color.Red;
            this.pobraneBydgoszcz.Location = new System.Drawing.Point(160, 182);
            this.pobraneBydgoszcz.Name = "pobraneBydgoszcz";
            this.pobraneBydgoszcz.Size = new System.Drawing.Size(76, 13);
            this.pobraneBydgoszcz.TabIndex = 15;
            this.pobraneBydgoszcz.Text = "Nie pobrane";
            // 
            // aktPoznan
            // 
            this.aktPoznan.AutoSize = true;
            this.aktPoznan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktPoznan.ForeColor = System.Drawing.Color.Red;
            this.aktPoznan.Location = new System.Drawing.Point(286, 71);
            this.aktPoznan.Name = "aktPoznan";
            this.aktPoznan.Size = new System.Drawing.Size(75, 13);
            this.aktPoznan.TabIndex = 16;
            this.aktPoznan.Text = "Nieaktualne";
            // 
            // aktWroclaw
            // 
            this.aktWroclaw.AutoSize = true;
            this.aktWroclaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktWroclaw.ForeColor = System.Drawing.Color.Red;
            this.aktWroclaw.Location = new System.Drawing.Point(286, 105);
            this.aktWroclaw.Name = "aktWroclaw";
            this.aktWroclaw.Size = new System.Drawing.Size(75, 13);
            this.aktWroclaw.TabIndex = 17;
            this.aktWroclaw.Text = "Nieaktualne";
            // 
            // aktSzczecin
            // 
            this.aktSzczecin.AutoSize = true;
            this.aktSzczecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktSzczecin.ForeColor = System.Drawing.Color.Red;
            this.aktSzczecin.Location = new System.Drawing.Point(286, 142);
            this.aktSzczecin.Name = "aktSzczecin";
            this.aktSzczecin.Size = new System.Drawing.Size(75, 13);
            this.aktSzczecin.TabIndex = 18;
            this.aktSzczecin.Text = "Nieaktualne";
            // 
            // aktBydgoszcz
            // 
            this.aktBydgoszcz.AutoSize = true;
            this.aktBydgoszcz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktBydgoszcz.ForeColor = System.Drawing.Color.Red;
            this.aktBydgoszcz.Location = new System.Drawing.Point(286, 182);
            this.aktBydgoszcz.Name = "aktBydgoszcz";
            this.aktBydgoszcz.Size = new System.Drawing.Size(75, 13);
            this.aktBydgoszcz.TabIndex = 19;
            this.aktBydgoszcz.Text = "Nieaktualne";
            // 
            // Aktualizacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 253);
            this.Controls.Add(this.aktBydgoszcz);
            this.Controls.Add(this.aktSzczecin);
            this.Controls.Add(this.aktWroclaw);
            this.Controls.Add(this.aktPoznan);
            this.Controls.Add(this.pobraneBydgoszcz);
            this.Controls.Add(this.pobraneSzczecin);
            this.Controls.Add(this.pobraneWroclaw);
            this.Controls.Add(this.pobranePoznan);
            this.Controls.Add(this.checkBydgoszcz);
            this.Controls.Add(this.checkSzczecin);
            this.Controls.Add(this.checkWroclaw);
            this.Controls.Add(this.checkPoznan);
            this.Controls.Add(this.labelBydgoszcz);
            this.Controls.Add(this.labelSzczecin);
            this.Controls.Add(this.labelWroclaw);
            this.Controls.Add(this.labelPoznan);
            this.Controls.Add(this.Dostepne);
            this.Controls.Add(this.Zamknij);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.NoDownload);
            this.Name = "Aktualizacja";
            this.Text = "Aktualizacja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NoDownload;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button Zamknij;
        private System.Windows.Forms.Label Dostepne;
        private System.Windows.Forms.Label labelPoznan;
        private System.Windows.Forms.Label labelWroclaw;
        private System.Windows.Forms.Label labelSzczecin;
        private System.Windows.Forms.Label labelBydgoszcz;
        private System.Windows.Forms.CheckBox checkPoznan;
        private System.Windows.Forms.CheckBox checkWroclaw;
        private System.Windows.Forms.CheckBox checkSzczecin;
        private System.Windows.Forms.CheckBox checkBydgoszcz;
        private System.Windows.Forms.Label pobranePoznan;
        private System.Windows.Forms.Label pobraneWroclaw;
        private System.Windows.Forms.Label pobraneSzczecin;
        private System.Windows.Forms.Label pobraneBydgoszcz;
        private System.Windows.Forms.Label aktPoznan;
        private System.Windows.Forms.Label aktWroclaw;
        private System.Windows.Forms.Label aktSzczecin;
        private System.Windows.Forms.Label aktBydgoszcz;
    }
}