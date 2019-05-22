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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1370, 726);
        }
        int P1_x = 60, P1_y = 60;// all_distance = 70;
        private void Move_On_Line1(PaintEventArgs e)
        {
            int counter = 25;
            if (P1_x == 60)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, P1_x, P1_y, 5, 5);
                    P1_x = P1_x + (int)1;
                    P1_y = P1_y + (int)1;
                }

                //label1.Text = x_ex.ToString();
                //int sub = all_distance - x_ex;    
            }
            else if (P1_x == 85)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P1_x, P1_y, 5, 5);
                    P1_x = P1_x + (int)1;
                    P1_y = P1_y + (int)1;
                }
                //label2.Text = x_ex.ToString();
                //start_1st_Stop(e);

            }
            else if (P1_x == 110)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, P1_x, P1_y, 5, 5);
                    P1_x = P1_x + (int)1;
                    P1_y = P1_y + (int)1;
                }
                //label3.Text = x_ex.ToString();
            }
            else if (P1_x == 135)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P1_x, P1_y, 5, 5);
                    P1_x = P1_x + (int)1;
                    P1_y = P1_y + (int)1;
                } //label4.Text = x_ex.ToString();
            }
            else if (P1_x == 160)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, P1_x, P1_y, 5, 5);
                    P1_x = P1_x + (int)1;
                    P1_y = P1_y + (int)1;
                } //label5.Text = x_ex.ToString();
            }
            else if (P1_x == 185)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P1_x, P1_y, 5, 5);
                    P1_x = P1_x + (int)1;
                    P1_y = P1_y + (int)1;
                } //label6.Text = x_ex.ToString();
            }
            else if (P1_x == 210)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, P1_x, P1_y, 5, 5);
                    P1_x = P1_x + (int)1;
                    P1_y = P1_y + (int)1;
                }// label7.Text = x_ex.ToString();
            }
            else if (P1_x == 235)
            {
                e.Graphics.FillRectangle(Brushes.Red, P1_x, P1_y, 5, 5);

            }
        }

        int P2_x = 235, P2_y = 235;
        private void Move_On_Line2(PaintEventArgs e)
        {
            int counter = 1;
            if (P2_x == 235)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Green, P2_x, P2_y, 5, 5);
                    P2_x = P2_x + (int)10;
                }
            }
            else if (P2_x == 245)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Green, P2_x, P2_y, 5, 5);
                    P2_x = P2_x + (int)10;
                    P2_y = P2_y + (int)1;
                }

            }
            else if (P2_x == 255)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Green, P2_x, P2_y, 5, 5);
                    P2_x = P2_x + (int)10;

                }

            }
            else if (P2_x == 265)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Green, P2_x, P2_y, 5, 5);
                    P2_x = P2_x + (int)10;
                    P2_y = P2_y + (int)1;
                }

            }
            else if (P2_x == 275)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Green, P2_x, P2_y, 5, 5);
                    P2_x = P2_x + (int)10;

                }

            }
            else if (P2_x == 285)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Green, P2_x, P2_y, 5, 5);
                    P2_x = P2_x + (int)10;
                    P2_y = P2_y + (int)1;
                }

            }
            else if (P2_x == 295)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Green, P2_x, P2_y, 5, 5);
                    P2_x = P2_x + (int)10;

                }

            }
            else if (P2_x == 305)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Green, P2_x, P2_y, 5, 5);
                    P2_x = P2_x + (int)10;
                    P2_y = P2_y + (int)1;
                }

            }
            else if (P2_x == 315)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Green, P2_x, P2_y, 5, 5);
                    P2_x = P2_x + (int)10;

                }

            }
            else if (P2_x == 325)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Green, P2_x, P2_y, 5, 5);
                    P2_x = P2_x + (int)5;
                    P2_y = P2_y + (int)1;
                }

            }
            else if (P2_x == 330)
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Green, P2_x, P2_y, 5, 5);

                }

            }
        }
        int P3_x = 330, P3_y = 240;
        private void Move_On_Line3(PaintEventArgs e)
        {
            int counter = 1;
            if (P3_x == 330 && P3_y == 240)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P3_x, P3_y, 5, 5);
                    P3_y = P3_y + (int)10;
                }
            }
            else if (P3_x == 330 && P3_y == 250)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P3_x, P3_y, 5, 5);
                    P3_x = P3_x - (int)9;
                    P3_y = P3_y + (int)10;
                }
            }
            else if (P3_x == 321 && P3_y == 260)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P3_x, P3_y, 5, 5);
                    P3_x = P3_x - (int)9;
                    P3_y = P3_y + (int)10;
                }
            }
            else if (P3_x == 312 && P3_y == 270)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P3_x, P3_y, 5, 5);
                    P3_x = P3_x - (int)9;
                    P3_y = P3_y + (int)10;
                }
            }
            else if (P3_x == 303 && P3_y == 280)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P3_x, P3_y, 5, 5);
                    P3_x = P3_x - (int)9;
                    P3_y = P3_y + (int)10;
                }
            }
            else if (P3_x == 294 && P3_y == 290)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P3_x, P3_y, 5, 5);
                    P3_x = P3_x - (int)9;
                    P3_y = P3_y + (int)10;
                }
            }
            else if (P3_x == 285 && P3_y == 300)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P3_x, P3_y, 5, 5);

                }
            }
        }

        int P4_x = 750, P4_y = 300;
        private void Move_On_Line4(PaintEventArgs e)
        {
            int counter = 1;
            if (P4_x == 750)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
                    P4_x = P4_x - (int)35;
                }
            }
            else if (P4_x == 715)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
                    P4_x = P4_x - (int)35;
                }
            }

            else if (P4_x == 680)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
                    P4_x = P4_x - (int)35;
                }
            }
            else if (P4_x == 645)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
                    P4_x = P4_x - (int)35;
                }
            }
            else if (P4_x == 610)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
                    P4_x = P4_x - (int)35;
                }
            }
            else if (P4_x == 575)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
                    P4_x = P4_x - (int)35;
                }
            }
            else if (P4_x == 540)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
                    P4_x = P4_x - (int)35;
                }
            }
            else if (P4_x == 505)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
                    P4_x = P4_x - (int)35;
                }
            }
            else if (P4_x == 470)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
                    P4_x = P4_x - (int)35;
                }
            }
            else if (P4_x == 435)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
                    P4_x = P4_x - (int)35;
                }
            }
            else if (P4_x == 400)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
                    P4_x = P4_x - (int)35;
                }
            }
            else if (P4_x == 365)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
                    P4_x = P4_x - (int)35;
                }
            }
            else if (P4_x == 330)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
                    P4_x = P4_x - (int)35;
                }
            }
            else if (P4_x == 295)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
                    P4_x = P4_x - (int)10;
                }
            }
            else if (P4_x == 285)//285, 300
            {
                e.Graphics.FillRectangle(Brushes.Red, P4_x, P4_y, 5, 5);
            }

        }
        int P5_x = 285, P5_y = 300;

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "insert into Administrators ([User_Name],[Password]) values (?,?)";
        //    cmd.Parameters.AddWithValue("@User_Name", textBox1.Text);
        //    cmd.Parameters.AddWithValue("@Password", textBox2.Text);
        //    cmd.Connection = con;
        //    con.Open();
        //    cmd.ExecuteNonQuery();
        //    System.Windows.Forms.MessageBox.Show("An Item has been successfully added", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        //}

        private void BackEndInterface_Paint(object sender, PaintEventArgs e)
        {
            Move_On_Line1(e);
            Move_On_Line2(e);
            Move_On_Line3(e);
            Move_On_Line4(e);
            Move_On_Line5(e);
            Move_On_Line6(e);
            DrawLines Lines = new DrawLines();
            Lines.Draw_Track(e);
            Lines.Draw_adjacent_Track(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        int x = 0, y = 0;

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Implement i = new Implement();
            i.Show();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            //base.OnMouseMove(e);
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Navy);
            Pen erase = new Pen(Color.White);
            g.DrawLine(erase, 0, 0, x, y);
            x = e.X; y = e.Y;
            g.DrawLine(p, 0, 0, x, y);
            label1.Location = new Point(x - label1.Width, y);
            label2.Location = new Point(x, y - label2.Height);
            label1.Text = x.ToString();
            label2.Text = y.ToString();
        }









        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    Move_On_Line5();
        //}


        bool display = false;

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Display b = new Display();
            b.Show();
        }

        private void Move_On_Line5(PaintEventArgs l)
        {
            timer1.Start();
            int counter = 1;
            if (P5_x == 285)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
                    P5_x = P5_x + (int)35;
                }
            }
            else if (P5_x == 320)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
                    P5_x = P5_x + (int)35;
                }
            }
            else if (P5_x == 355)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
                    P5_x = P5_x + (int)35;
                }
            }
            else if (P5_x == 390)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
                    P5_x = P5_x + (int)35;
                }
            }
            else if (P5_x == 425)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
                    P5_x = P5_x + (int)10;
                }
            }
            else if (P5_x == 435)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
                    P5_x = P5_x + (int)3;
                }

            }
            //    int P6_x=435,P6_y=290;

            //int counter2 = 1;
            //if (P6_y == 290)//285, 300
            //{
            //    for (int i = 0; i < counter2; i++)
            //    {
            //        e.Graphics.FillRectangle(Brushes.Blue, P6_x, P6_y, 5, 5);
            //        //P6_x = P6_x - (int)0.5;
            //        P6_y = P6_y - (int)10;
            //    }
            //}
            //else if (P6_y == 300)//285, 300
            //{
            //    for (int i = 0; i < counter; i++)
            //    {
            //        e.Graphics.FillRectangle(Brushes.Blue, P6_x, P6_y, 5, 5);
            //        //P6_x = P6_x + (int)0.5;
            //        P6_y = P6_y - (int)10;
            //    }
            //}
            //else if (P6_x == 435)//285, 300
            //{
            //    for (int i = 0; i < counter; i++)
            //    {
            //        e.Graphics.FillRectangle(Brushes.Blue, P6_x, P6_y, 5, 5);
            //        P6_x = P6_x + (int)25;
            //        //P6_y = P6_y - (int)0.5;
            //    }
            //}
            //else if (P6_x == 460)//285, 300
            //{
            //    for (int i = 0; i < counter; i++)
            //    {
            //        e.Graphics.FillRectangle(Brushes.Blue, P6_x, P6_y, 5, 5);
            //        P6_x = P6_x + (int)30;
            //        //P6_y = P6_y + (int)0.5;
            //    }
            //}
            //else if (P6_x == 490)//285, 300
            //{
            //    e.Graphics.FillRectangle(Brushes.Blue, P6_x, P6_y, 5, 5);

            //}


            else if (P5_x == 470)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
                    P5_x = P5_x + (int)35;
                }
            }
            else if (P5_x == 505)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
                    P5_x = P5_x + (int)35;
                }
            }
            else if (P5_x == 540)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
                    P5_x = P5_x + (int)35;
                }
            }
            else if (P5_x == 575)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
                    P5_x = P5_x + (int)35;
                }
            }
            else if (P5_x == 610)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
                    P5_x = P5_x + (int)35;
                }
            }
            else if (P5_x == 645)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
                    P5_x = P5_x + (int)35;
                }
            }
            else if (P5_x == 680)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
                    P5_x = P5_x + (int)35;
                }
            }
            else if (P5_x == 715)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
                    P5_x = P5_x + (int)35;
                }
            }
            else if (P5_x == 750)//285, 300
            {
                l.Graphics.FillRectangle(Brushes.Blue, P5_x, P5_y, 5, 5);
            }



        }
        int P6_x = 435, P6_y = 300;
        private void Move_On_Line6(PaintEventArgs e)
        {
            int counter = 1;
            if (P6_y == 300)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, P6_x, P6_y, 5, 5);
                    //P6_x = P6_x - (int)0.5;
                    P6_y = P6_y - (int)10;
                }
            }
            else if (P6_y == 290)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, P6_x, P6_y, 5, 5);
                    //P6_x = P6_x + (int)0.5;
                    P6_y = P6_y - (int)10;
                }
            }
            else if (P6_x == 435)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, P6_x, P6_y, 5, 5);
                    P6_x = P6_x + (int)25;
                    //P6_y = P6_y - (int)0.5;
                }
            }
            else if (P6_x == 460)//285, 300
            {
                for (int i = 0; i < counter; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, P6_x, P6_y, 5, 5);
                    P6_x = P6_x + (int)30;
                    //P6_y = P6_y + (int)0.5;
                }
            }
            else if (P6_x == 490)//285, 300
            {
                e.Graphics.FillRectangle(Brushes.Blue, P6_x, P6_y, 5, 5);

            }

        }
    }
}
