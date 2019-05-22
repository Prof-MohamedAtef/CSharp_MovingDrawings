using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace EX_Moving_P_If_State
{
    public partial class Form1 : Form
    {
        public OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Mine\My Developed Codes\MovingPoints_research\Moving_Points_DB_Connection\Database3.accdb;Persist Security Info=False;");
        public OleDbCommand cmd = new OleDbCommand();
        public DataTable dt = new DataTable();
        public OleDbDataReader read;
        public OleDbDataAdapter da = new OleDbDataAdapter();
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(540, 357);
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "insert into Administrators ([User_Name],[Password]) values (?,?)";
        //    cmd.Parameters.AddWithValue("@User_Name", textBox1.Text);
        //    cmd.Parameters.AddWithValue("@Password", textBox2.Text);
        //    cmd.Connection = con;
        //    con.Open();
        //    cmd.ExecuteNonQuery();
        // System.Windows.Forms.MessageBox.Show("An Item has been successfully added", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
        //}

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    Move_On_Line5();
        //}

        bool display = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.Increment(20);
            
            if(toolStripProgressBar1.Value==100)
            {
                //label9.Text = Convert.ToString(progressBar1.GetLifetimeService()); // null value
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 700;
            
        }

        private void displayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Display d = new Display();
            d.Show();
        }

        public void Btn_Login_Select_Admins_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("select * from Administrators where User_Name='" + Txt_LogIn_UserName.Text + "'and Password='" + Txt_LogIn_Password.Text + "'", con);
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                LBL_LogIn_Status.Text = "User Name or Password are Invalid, Please Try Again ! ";
            }
            else if (dt.Rows.Count > 0)
            {
                LBL_LogIn_Status.Text = "Logged In Successfully";
                this.Hide();
                Implement i = new Implement();
                i.Show();
            }
            LoadPanel l = new LoadPanel();
            
            if (Txt_LogIn_UserName.Text=="mohamed_718@yahoo.com"&&Txt_LogIn_Password.Text=="123abc")
            {
                
            }
        }

        private void Btn_Insert_Administrators_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "insert into Administrators ([User_Name],[Password]) values ('" + Txt_Regis_UserName.Text + "','" + Txt_Regis_Password .Text+ "')";
                command.ExecuteNonQuery();
                ToolStripStatusLabel_Registeration.Text = "Is Registered !? " + " -- Yes ";
            }
            catch (Exception)
            {
                LBL_LogIn_Status.Text = "Is Registered !? " + " -- No ";

            }
        }

        private void Btn_Register_Show_Click(object sender, EventArgs e)
        {
            groupBox_Register.Visible = true;
            Btn_Register_Show.Visible = false;
            Btn_Login_Show.Visible = true;

        }

        private void Btn_Login_Show_Click(object sender, EventArgs e)
        {
            groupBox_LogIN.Visible = true;
            Btn_Login_Show.Visible = false;
            Btn_Register_Show.Visible = true; 

        }

        

        

        
    }
    public class LoadPanel :Implement
    {

    }
}
