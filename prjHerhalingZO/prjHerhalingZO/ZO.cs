using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjHerhalingZO
{
    internal class ZO
    {
        public Graphics g { get; set; }
        public int breedte { get; set; }

        const float mmToPxFactor = 3.7795276f;

        //constructor
        public ZO(Graphics graphics, int W) {
            g = graphics;
            breedte = W;

            //zo tekeken met px ipv mm
            tekenZO(graphics, mmToPx(W));
        }

        private void tekenZO(Graphics graphics, int W)
        {
            Random random = new Random();
            Point startPunt = new Point(random.Next(300), random.Next(300));
            Point eindPunt = new Point(startPunt.X, startPunt.Y + W * 20);
            tekenLijn(graphics, startPunt, eindPunt);

            for (int i = 0; i < 20; i++)
            {
                startPunt.Y += W;
                eindPunt.X += W;
                tekenLijn(graphics, startPunt, eindPunt);
            }
        }

        private int mmToPx(int mm)
        {
            return (int)(mm * mmToPxFactor);
        }

        private void tekenLijn(Graphics graphics, Point start, Point eind)
        {
            Random random = new Random();
            graphics.DrawLine(new Pen(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)), 1), start, eind);
        }
    }
}
