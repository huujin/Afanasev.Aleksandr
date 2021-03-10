using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace многоугольники
{
    public delegate void RCHEventer(object sender, RadiusEventArgs e);
    public partial class Form2 : Form
    {
        public RCHEventer Rch;

        public Form2()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            int v;
            if (trackBar1.Value != 0)
            {
                 v = Convert.ToInt32(trackBar1.Value) * 10;
            }
            else
            {
                 v = 10; 
            }
            if(this.Rch != null)
            {
                this.Rch(this, new RadiusEventArgs(v));
            }
        }
    }
    //radddddddd
    public class RadiusEventArgs:EventArgs
    {
        public int rad { get; set; }
        public RadiusEventArgs(int r)
        { rad = r; }
    }
}
