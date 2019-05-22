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
    public partial class Mege : Form
    {
        public Mege(List<string> tablica_kierunkow)
        {
           
            InitializeComponent();
            flowLayoutPanel1 = F_DodajLinie(flowLayoutPanel1, tablica_kierunkow);
        }
        static Mege MsgBox; static DialogResult result = DialogResult.No;static string odpo;
        public string  Show()
        {

            odpo = "1";
            this.ShowDialog();

            return odpo;

        }


        public FlowLayoutPanel F_DodajLinie(FlowLayoutPanel flow,List<string> tab)
        {
            
            for (int i = 0; i < tab.Count; i++)
            {
                ButtonLinia L = addLabel(tab[i],i);
                flow.Controls.Add(L);
                L.Click += new EventHandler(this.labelClick);
            }
            return flow;
        }

        private void labelClick(object sender, EventArgs e)
        {
            Rozklad.ButtonLinia obecna = (Rozklad.ButtonLinia)sender;
            odpo = obecna.i;
            Close();
        }

        ButtonLinia addLabel(string s ,int i)
        {
            Rozklad.ButtonLinia L = new Rozklad.ButtonLinia();

            L.Name = s;
            L.Text = s;
            L.ForeColor = Color.Cornsilk;
            L.BackColor = Color.DimGray;
            L.Font = new Font("Serif", 8, FontStyle.Bold);
            L.Width = 300;
            L.Height = 30;
            L.TextAlign = ContentAlignment.MiddleCenter;
            L.Margin = new Padding(5);
            L.i = (i+1).ToString();
            
            return L;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            odpo = "1";
            MsgBox.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = DialogResult.None;
            odpo = "2";
            MsgBox.Close();

        }
    }
}
