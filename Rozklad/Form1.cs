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
    public partial class Form1 : Form
    {
        gtf.Komunikacja kom;
        public List<string> jakiePobralo = new List<string>();
        public Form1(List<string> jp)
        {
            jakiePobralo = jp;
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in jakiePobralo)
            {
                miastobox.Items.Add(s);
            }
            kom = new gtf.Komunikacja(jakiePobralo[0],progressBar1);

            
            flowLayoutPanel1 = kom.F_DodajLinie(flowLayoutPanel1);
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void miastobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kom = new gtf.Komunikacja(miastobox.Text,progressBar1);
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1 = kom.F_DodajLinie(flowLayoutPanel1);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
