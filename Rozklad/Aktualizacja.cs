using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Net;
using System.IO.Compression;

namespace Rozklad
{
    public partial class Aktualizacja : Form
    {
        public Dane dane;
        public List<string> jakieMiasta= new List<string>();
        public bool wyjscie = true;
        public Aktualizacja()
        {
            InitializeComponent();
            dane = new Dane();

            ZaktualizujLable();
        }

        private void ZaktualizujLable()
        {
            foreach (string s in dane.dostepne_miasta)
            {
                if (File.Exists(dane.podfoldery[s].FullName + "\\" + s + "GTFS.zip"))
                {
                    if (labelPoznan.Text == s) { pobranePoznan.Text = "Pobrane"; pobranePoznan.ForeColor = Color.Green; }
                    if (labelSzczecin.Text == s) { pobraneSzczecin.Text = "Pobrane"; pobraneSzczecin.ForeColor = Color.Green; }
                    if (labelWroclaw.Text == s) { pobraneWroclaw.Text = "Pobrane"; pobraneWroclaw.ForeColor = Color.Green; }
                    if (labelBydgoszcz.Text == s) { pobraneBydgoszcz.Text = "Pobrane"; pobraneBydgoszcz.ForeColor = Color.Green; }
                }
                else
                {
                    if (labelPoznan.Text == s) { pobranePoznan.Text = "Niepobrane"; pobranePoznan.ForeColor = Color.Red; }
                    if (labelSzczecin.Text == s) { pobraneSzczecin.Text = "Niepobrane"; pobraneSzczecin.ForeColor = Color.Red; }
                    if (labelWroclaw.Text == s) { pobraneWroclaw.Text = "Niepobrane"; pobraneWroclaw.ForeColor = Color.Red; }
                    if (labelBydgoszcz.Text == s) { pobraneBydgoszcz.Text = "Niepobrane"; pobraneBydgoszcz.ForeColor = Color.Red; }
                }
            }
            foreach (string s in dane.dostepne_miasta)
            {
                if (dane.SprawdzanieAktualnosci(s) == true)
                {
                    if (labelPoznan.Text == s) { aktPoznan.Text = "Nieaktualne"; aktPoznan.ForeColor = Color.Red; }
                    if (labelSzczecin.Text == s) { aktSzczecin.Text = "Nieaktualne"; aktSzczecin.ForeColor = Color.Red; }
                    if (labelWroclaw.Text == s) { aktWroclaw.Text = "Nieaktualne"; aktWroclaw.ForeColor = Color.Red; }
                    if (labelBydgoszcz.Text == s) { aktBydgoszcz.Text = "Nieaktualne"; aktBydgoszcz.ForeColor = Color.Red; }
                }
                else
                {
                    if (labelPoznan.Text == s) { aktPoznan.Text = "Aktualne"; aktPoznan.ForeColor = Color.Green; }
                    if (labelSzczecin.Text == s) { aktSzczecin.Text = "Aktualne"; aktSzczecin.ForeColor = Color.Green; }
                    if (labelWroclaw.Text == s) { aktWroclaw.Text = "Aktualne"; aktWroclaw.ForeColor = Color.Green; }
                    if (labelBydgoszcz.Text == s) { aktBydgoszcz.Text = "Aktualne"; aktBydgoszcz.ForeColor = Color.Green; }
                }
            }
        }
        private bool AnyPobrane()
        {
            int i = 0;
            foreach (string s in dane.dostepne_miasta)
            {
                if (File.Exists(dane.podfoldery[s].FullName + "\\" + s + "GTFS.zip"))
                {
                    i++;
                }
               
            }
            if (i == 0) return false;
            else return true;
        }
        private List<string> JakiePobrane()
        {
            List<string> takiePobralo = new List<string>();
            takiePobralo.Clear();
            foreach (string s in dane.dostepne_miasta)
            {
                if (File.Exists(dane.podfoldery[s].FullName + "\\" + s + "GTFS.zip"))
                {
                    takiePobralo.Add(s);
                }
                
            }
            return takiePobralo;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NoDownload_Click(object sender, EventArgs e)
        {
            if(AnyPobrane()==false)
            {
                MessageBox.Show("Brak jakich kolwiek pobranych miast!","Brak danych",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                jakieMiasta.Clear();
                jakieMiasta = JakiePobrane();
                wyjscie = false;
                Close();
            }
        }

        private void Download_Click(object sender, EventArgs e)
        {
            dane.wybrane_miasta.Clear();
            List<string> zachaczone = new List<string>();

            if (checkPoznan.Checked == true) dane.wybrane_miasta.Add("Poznan");
            if (checkSzczecin.Checked == true) dane.wybrane_miasta.Add("Szczecin");
            if (checkBydgoszcz.Checked == true) dane.wybrane_miasta.Add("Bydgoszcz");
            if (checkWroclaw.Checked == true) dane.wybrane_miasta.Add("Wroclaw");

            if (dane.wybrane_miasta.Count != 0)
            {
                foreach (string s in dane.wybrane_miasta)
                {
                    dane.PobierzMiasta(s);
                }
                ZaktualizujLable();
            }
            else MessageBox.Show("Niewybrano zadnego miasta");

        }

        private void Zamknij_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
