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
    class Move_On_Line
    {
        int x_ex = 60, y_ex = 60;// all_distance = 70;
        public void Move_On_Line1(PaintEventArgs e)
        {
            int counter = 25;
            if (x_ex == 60)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, x_ex, y_ex, 5, 5);
                    x_ex = x_ex + (int)1;
                    y_ex = y_ex + (int)1;
                }

                //label1.Text = x_ex.ToString();
                //int sub = all_distance - x_ex;    
            }
            else if (x_ex == 85)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, x_ex, y_ex, 5, 5);
                    x_ex = x_ex + (int)1;
                    y_ex = y_ex + (int)1;
                }
                //label2.Text = x_ex.ToString();
                //start_1st_Stop(e);

            }
            else if (x_ex == 110)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, x_ex, y_ex, 5, 5);
                    x_ex = x_ex + (int)1;
                    y_ex = y_ex + (int)1;
                }
                //label3.Text = x_ex.ToString();
            }
            else if (x_ex == 135)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, x_ex, y_ex, 5, 5);
                    x_ex = x_ex + (int)1;
                    y_ex = y_ex + (int)1;
                } //label4.Text = x_ex.ToString();
            }
            else if (x_ex == 160)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, x_ex, y_ex, 5, 5);
                    x_ex = x_ex + (int)1;
                    y_ex = y_ex + (int)1;
                } //label5.Text = x_ex.ToString();
            }
            else if (x_ex == 185)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, x_ex, y_ex, 5, 5);
                    x_ex = x_ex + (int)1;
                    y_ex = y_ex + (int)1;
                } //label6.Text = x_ex.ToString();
            }
            else if (x_ex == 210)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, x_ex, y_ex, 5, 5);
                    x_ex = x_ex + (int)1;
                    y_ex = y_ex + (int)1;
                }// label7.Text = x_ex.ToString();
            }
            else if (x_ex == 235)
            {
                e.Graphics.FillRectangle(Brushes.Red, x_ex, y_ex, 5, 5);

            }
        }
        
    }
}
