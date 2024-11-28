using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHerhalingZO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Graphics g = pnlCanvas.CreateGraphics();
            g.Clear(Color.White);
        }

        private void btnZO_Click(object sender, EventArgs e)
        {
            int w = 0;
            //invoer controleren
            if (int.TryParse(txtBreedtew.Text, out w))
            {
                if (w > 0 && w < 6)
                { 
                    //invoer is corect, ZO tekenen vanuit klasse
                    ZO zo = new ZO(pnlCanvas.CreateGraphics(), w);
                }
                else
                {
                    MessageBox.Show("Gelieve een getal in te geven tussen 1 en 5.", "Error: Invoer was niet tussen 1 en 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Gelieve een geheel getal in te geven.", "Error: Invoer was niet numeriek", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
