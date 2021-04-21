using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jryf
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Black, 5);  // Перо для рисования
            Graphics g = CreateGraphics();
            g.DrawEllipse(pn, 200, 200, 300, 200);
        }
    }
}
