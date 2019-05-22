using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gtf;

namespace Rozklad
{
    public partial class MPrzystanki : Form
    {
        public MPrzystanki(List<gtf.Stops> przym,gtf.Routes linia)
        {

            InitializeComponent();
            flowLayoutPanel1 = F_DodajLinie(flowLayoutPanel1, przym,linia);
           
        }

        

        static gtf.Stops odpo;

        public gtf.Stops Show()
        {

            odpo = new gtf.Stops();
            this.ShowDialog();

            return odpo;

        }


        public FlowLayoutPanel F_DodajLinie(FlowLayoutPanel flow, List<gtf.Stops> przym,gtf.Routes routes)
        {

            foreach(gtf.Stops S in przym)
            {
                ButtonLinia L = addLabel(S,routes);
                flow.Controls.Add(L);
                ButtonLinia K = addZona(S);
                flow.Controls.Add(K);
                L.Click += new EventHandler(this.labelClick);
            }
            return flow;
        }
        ButtonLinia addLabel(gtf.Stops S,gtf.Routes routes)
        {
            Rozklad.ButtonLinia L = new Rozklad.ButtonLinia();

            L.Name = S.stop_name;
            L.Text = S.stop_name;
            L.ForeColor = Color.Black;
            L.BackColor = Color.Gray;
            L.Font = new Font("Serif", 8, FontStyle.Bold);
            L.Width = 270;
            L.Height = 30;
            L.TextAlign = ContentAlignment.MiddleCenter;
            L.Margin = new Padding(5);
            L.przystanek = S;

            return L;
        }
        ButtonLinia addZona(Stops S)
        {
            ButtonLinia L = new Rozklad.ButtonLinia();

            if (S.zone_id != null && S.zone_id != string.Empty && S.zone_id != "zone_id") L.Name = S.zone_id;
            else L.Name = S.stop_id;
            if (S.zone_id != null && S.zone_id != string.Empty && S.zone_id != "zone_id") L.Text = S.zone_id;
            else L.Text = "?";
            L.ForeColor = Color.WhiteSmoke;
            if (S.zone_id == "A") L.BackColor = Color.DarkGreen;
            else if (S.zone_id == "B") L.BackColor = Color.Red;
            else if (S.zone_id == "C") L.BackColor = Color.Gold;
            else if (S.zone_id == null || S.zone_id == string.Empty || S.zone_id == "zone_id") L.BackColor = Color.Black;
            L.Font = new Font("Serif", 8, FontStyle.Bold);
            L.Width =  30;
            L.Height = 30;
            L.TextAlign = ContentAlignment.MiddleCenter;
            L.Margin = new Padding(5);
            L.przystanek = S;

            return L;
        }
        private void labelClick(object sender, EventArgs e)
        {
            Rozklad.ButtonLinia obecna = (Rozklad.ButtonLinia)sender;
            odpo = obecna.przystanek;
            Close();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
