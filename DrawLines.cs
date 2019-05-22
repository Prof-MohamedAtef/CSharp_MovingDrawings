using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_Moving_P_If_State
{
    class DrawLines
    {
        public void Draw_Track(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, 60, 60, 235, 235);
            e.Graphics.DrawLine(Pens.Black, 235, 235, 330, 240);
            e.Graphics.DrawLine(Pens.Black, 330, 240, 285, 300);
            e.Graphics.DrawLine(Pens.Black, 285, 300, 750, 300);
            //e.Graphics.DrawLine(Pens.Green, 750, 300, 630, 255);
            //e.Graphics.DrawLine(Pens.Green, 630, 255, 755, 255);
            Point []Cairo_PortSaid_Track=new Point[]
            {
                new Point (1167,147),
                new Point(1091,297),
                new Point(1174,406),
                new Point(1136,445),
                new Point(1159,534),
                new Point(944,544),
                new Point(847,614),
                new Point(885,682),
                new Point(785,688),

            };
            e.Graphics.DrawLines(Pens.Green, Cairo_PortSaid_Track);
            Point[] Cairo_Alex_Track = new Point[]
            {
                new Point (759,680),
                new Point(759,521),
                new Point(723,471),
                new Point(681,366),
                new Point(615,350),
                new Point(524,340),
                new Point(459,305),
                new Point(479,248),
                new Point(325,178),
                new Point(253,229),
                new Point(171,309),

            };
            e.Graphics.DrawLines(Pens.Green, Cairo_Alex_Track);
        }
        public void Draw_adjacent_Track(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Red, 435, 300, 435, 280);
            e.Graphics.DrawLine(Pens.Green, 435, 280, 500, 280);
        }
    }
}
