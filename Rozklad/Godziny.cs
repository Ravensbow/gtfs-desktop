using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozklad
{

    public partial class Godziny : Form
    {
        
        public Godziny(List<string> poniedzialek,
        List<string> wtorek,
        List<string> sroda, 
        List<string> czwartek, 
        List<string> piatek, 
        List<string> sobota, 
        List<string> niedziela,string kierunek,string nr_lini,string nazwaprzytanku)
        {

            InitializeComponent();
            label1.Text = "Godziny odjazdu lini "+nr_lini+" z przystanku "+nazwaprzytanku+" w kirunku "+kierunek;
            flowLayoutPanel1 = F_DodajLinie(flowLayoutPanel1, poniedzialek);
            flowLayoutPanel2 = F_DodajLinie(flowLayoutPanel2, wtorek);
            flowLayoutPanel3 = F_DodajLinie(flowLayoutPanel3, sroda);
            flowLayoutPanel4 = F_DodajLinie(flowLayoutPanel4, czwartek);
            flowLayoutPanel5 = F_DodajLinie(flowLayoutPanel5, piatek);
            flowLayoutPanel6 = F_DodajLinie(flowLayoutPanel6, sobota);
            flowLayoutPanel7 = F_DodajLinie(flowLayoutPanel7, niedziela);

        }
        public void Show()
        {

           
            this.ShowDialog();

            

        }
        public FlowLayoutPanel F_DodajLinie(FlowLayoutPanel flow, List<string> dzien)
        {

            foreach (string S in dzien)
            {
                ButtonLinia L = addLabel(S);
                flow.Controls.Add(L);
                
            }
            return flow;
        }
        ButtonLinia addLabel(string S)
        {
            Rozklad.ButtonLinia L = new Rozklad.ButtonLinia();

            L.Name = S;
            L.Text = S;
            L.BackColor = Color.ForestGreen;
            L.ForeColor = Color.BlanchedAlmond;
            L.Font = new Font("Serif", 8, FontStyle.Bold);
            L.Width = 90;
            L.Height = 30;
            L.TextAlign = ContentAlignment.MiddleCenter;
            L.Margin = new Padding(5);
            return L;
        }
     



























        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
